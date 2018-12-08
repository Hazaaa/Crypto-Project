using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto_Lib;
using System.IO;
using System.Security.AccessControl;

namespace Crypto_Client.Other_Forms
{
    public partial class WatcherForm : Form
    {

        #region Attributes

        private ICrypto algorithm;

        private FileSystemWatcher watcher;

        private static string folderPath = @".\ToDo";
        private static string settingsFilePath = Path.Combine(folderPath, "WatcherSettings.txt");
        private static string queueFilePath = Path.Combine(folderPath, "Queue.txt");

        private Queue<FileInfo> filesToCryptDecrypt;
        private DateTime lastAccess;

        public WatcherForm(ICrypto algorithm)
        {
            InitializeComponent();

            filesToCryptDecrypt = new Queue<FileInfo>();

            InitializeControls(algorithm);
            CreateFolderAndFiles();
            InitializeWatcher();
        }

        #endregion

        #region FileWatcher

        public void InitializeWatcher()
        {
            watcher = new FileSystemWatcher();

            watcher.Path = folderPath;

            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.Deleted += Watcher_Deleted;

            // Starts monitoring
            watcher.EnableRaisingEvents = true;

            // Get files to queue that need to be processed
            FillQueue();
            ShowQueue();
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            FillQueue();
            ShowQueueThread();
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            FillQueue();
            ShowQueueThread();
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            FillQueue();
            ShowQueueThread();
        }

        #endregion

        #region Helper Functions

        public void FillQueue()
        {
            string time = File.ReadAllLines(settingsFilePath).FirstOrDefault();
            lastAccess = Convert.ToDateTime(time);

            // Get names of all files in folder
            string[] allFiles = Directory.GetFiles(folderPath);

            // Info of all files that need sto be processed
            List<FileInfo> filesToSave = allFiles.Where(x => !x.Contains("WatcherSettings.txt")).Select(x => new FileInfo(x)).OrderBy(x => x.LastAccessTime).ToList();

            if (filesToCryptDecrypt.Count != 0)
            {
                int numberToDelete = filesToCryptDecrypt.Count;
                for (int i = 0; i < numberToDelete; i++)
                {
                    filesToCryptDecrypt.Dequeue();
                }
            }

            foreach (var file in filesToSave)
            {
                filesToCryptDecrypt.Enqueue(file);
            }
        }

        // Fill list view control with list of files names
        public void ShowQueue()
        {
            if (lvFiles.Items.Count != 0)
            {
                int numberToDelete = lvFiles.Items.Count;
                for (int i = numberToDelete - 1; i >= 0; i--)
                {
                    lvFiles.Items.RemoveAt(i);
                }
            }

            string[] names = filesToCryptDecrypt.Select(x => x.Name).ToArray();

            foreach (var fileName in names)
            {
                lvFiles.Items.Add(fileName);
            }
        }

        // Diffrent approach because control can't be changed differently from another thread that is created in
        public void ShowQueueThread()
        {
            if (lvFiles.Items.Count != 0)
            {
                int numberToDelete = lvFiles.Items.Count;
                for (int i = numberToDelete - 1; i >= 0; i--)
                {
                    lvFiles.Invoke(new Action(() => lvFiles.Items.RemoveAt(i)));
                }
            }

            string[] names = filesToCryptDecrypt.Select(x => x.Name).ToArray();

            foreach (var fileName in names)
            {
                lvFiles.Invoke(new Action(() => lvFiles.Items.Add(fileName)));
            }
        }

        // If algorithm is XXTEA or SimpleSubstitution controls for key are visible for others are not
        public void InitializeControls(ICrypto algorithm)
        {
            this.algorithm = algorithm;
            string algorithmName = algorithm.ToString().Split('.').Last();
            lblAlgorithmName.Text = "Detected algorithm: " + algorithmName;

            if (algorithmName.Equals("XXTEAAlgorithm") || algorithmName.Equals("SimpleSubstitutionAlgorithm"))
            {
                txbKey.Visible = true;
                lblKey.Visible = true;
                btnRandomKey.Visible = true;
            }

            if (algorithmName.Equals("SHA2Algorithm"))
            {
                btnDecryptFiles.Visible = false;
            }
        }

        // Creates folder that will file watcher observe and files for queue and settings and if they are created read all content from them
        public void CreateFolderAndFiles()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(settingsFilePath))
            {
                File.Create(settingsFilePath);
            }
        }

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandomKey_Click(object sender, EventArgs e)
        {
            txbKey.Text = Encoding.Default.GetString(algorithm.GenerateRandomKey());
        }

        private void WatcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] currentTime = { DateTime.Now.ToString() };

            File.WriteAllLines(settingsFilePath, currentTime);

            watcher.Dispose();
        }

        private void btnCryptFiles_Click(object sender, EventArgs e)
        {
            if (lvFiles.Items.Count == 0)
                return;

            // Disable file watcher while crypting file because can get in conflict when file is deleted
            watcher.EnableRaisingEvents = false;

            if (!txbKey.Visible)
            {
                int numberOfFilesToCrypt = filesToCryptDecrypt.Count;

                for (int i = 0; i < numberOfFilesToCrypt; i++)
                {
                    string fileName = filesToCryptDecrypt.Peek().Name;
                    string originalPath = filesToCryptDecrypt.Peek().FullName;

                    byte[] file = File.ReadAllBytes(filesToCryptDecrypt.Dequeue().FullName);
                    byte[] cryptedFile = this.algorithm.Crypt(file);

                    string pathToSave = Path.Combine(@".\Crypted", fileName);
                    File.WriteAllBytes(pathToSave, cryptedFile);

                    if (File.Exists(pathToSave))
                    {
                        MessageBox.Show("File " + fileName + " was successfully crypted.", "Crypting successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File " + fileName + " wasn't crypted. There was error while crypting it.", "Crypting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    File.Delete(originalPath);
                }
            }
            else
            {
                int numberOfFilesToCrypt = filesToCryptDecrypt.Count;

                for (int i = 0; i < numberOfFilesToCrypt; i++)
                {
                    string fileName = filesToCryptDecrypt.Peek().Name;
                    string originalPath = filesToCryptDecrypt.Peek().FullName;

                    this.algorithm.SetKey(Encoding.Default.GetBytes(txbKey.Text));
                    byte[] file = File.ReadAllBytes(filesToCryptDecrypt.Dequeue().FullName);
                    byte[] cryptedFile = this.algorithm.Crypt(file);

                    string pathToSave = Path.Combine(@".\Crypted", fileName);
                    File.WriteAllBytes(pathToSave, cryptedFile);

                    if (File.Exists(pathToSave))
                    {
                        MessageBox.Show("File " + fileName + " was successfully crypted.", "Crypting successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File " + fileName + " wasn't crypted. There was error while crypting it.", "Crypting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    File.Delete(originalPath);
                }
            }

            // Show file list and enable watcher again
            FillQueue();
            ShowQueue();
            watcher.EnableRaisingEvents = true;
        }

        private void btnDecryptFiles_Click(object sender, EventArgs e)
        {
            if (lvFiles.Items.Count == 0)
                return;

            // Disable file watcher while crypting file because can get in conflict when file is deleted
            watcher.EnableRaisingEvents = false;

            if (!txbKey.Visible)
            {
                int numberOfFilesToDecrypt = filesToCryptDecrypt.Count;

                for (int i = 0; i < numberOfFilesToDecrypt; i++)
                {
                    string fileName = filesToCryptDecrypt.Peek().Name;
                    string originalPath = filesToCryptDecrypt.Peek().FullName;

                    this.algorithm.SetKey(Encoding.Default.GetBytes(txbKey.Text));
                    byte[] file = File.ReadAllBytes(filesToCryptDecrypt.Dequeue().FullName);
                    byte[] decryptedFile = this.algorithm.Decrypt(file);

                    string pathToSave = Path.Combine(@".\Decrypted", fileName);
                    File.WriteAllBytes(pathToSave, decryptedFile);

                    if (File.Exists(pathToSave))
                    {
                        MessageBox.Show("File " + fileName + " was successfully decrypted.", "Decrypting successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File " + fileName + " wasn't decrypted. There was error while decrypting it.", "Decrypting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    File.Delete(originalPath);
                }
            }
            else
            {
                int numberOfFilesToDecrypt = filesToCryptDecrypt.Count;

                for (int i = 0; i < numberOfFilesToDecrypt; i++)
                {
                    string fileName = filesToCryptDecrypt.Peek().Name;
                    string originalPath = filesToCryptDecrypt.Peek().FullName;

                    byte[] file = File.ReadAllBytes(filesToCryptDecrypt.Dequeue().FullName);
                    byte[] decryptedFile = this.algorithm.Decrypt(file);

                    string pathToSave = Path.Combine(@".\Decrypted", fileName);
                    File.WriteAllBytes(pathToSave, decryptedFile);

                    if (File.Exists(pathToSave))
                    {
                        MessageBox.Show("File " + fileName + " was successfully decrypted.", "Decrypting successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File " + fileName + " wasn't decrypted. There was error while decrypting it.", "Decrypting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    File.Delete(originalPath);
                }
            }


            FillQueue();
            ShowQueue();
            watcher.EnableRaisingEvents = true;
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WatcherForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #endregion
    }
}
