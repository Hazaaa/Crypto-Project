using Crypto_Client.CryptoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Client.Other_Forms
{
    public partial class CloudForm : Form
    {
        public CloudForm()
        {
            InitializeComponent();
        }

        #region Helper Functions

        public void showCloudFiles()
        {
            if (lvFiles.Items.Count != 0)
            {
                int numberToDelete = lvFiles.Items.Count;
                for (int i = numberToDelete - 1; i >= 0; i--)
                {
                    lvFiles.Items.RemoveAt(i);
                }
            }

            CryptoServiceClient cloudProxy = new CryptoServiceClient();

            string[] filesNames = cloudProxy.GetUploadedFilesNames();

            foreach (var fileName in filesNames)
            {
                string[] name = fileName.Split('\\');
                lvFiles.Items.Add(name.Last());
            }
        }

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CloudForm_Load(object sender, EventArgs e)
        {
            showCloudFiles();
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0)
            {
                return;
            }

            string localFilePath = "";
            string localFileName = lvFiles.SelectedItems[0].Text;
            int blockSize = 2048;

            CryptoServiceClient cloudProxy = new CryptoServiceClient();

            Stream inputStream = cloudProxy.DownloadFile(ref localFileName);
            string fileExtension = Path.GetExtension(localFileName);


            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.FileName = localFileName;
                sf.Filter = "(*" + fileExtension + ")|" + fileExtension;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    localFilePath = sf.FileName;
                }
                else
                {
                    return;
                }
            }

            using (FileStream writeStream = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[blockSize];

                do
                {
                    var bytesRead = inputStream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0) break;

                    //Then it's last block
                    if (bytesRead < blockSize)
                    {
                        var temp = new byte[bytesRead];
                        Array.Copy(buffer, temp, bytesRead);
                        buffer = temp;
                    }

                    writeStream.Write(buffer, 0, buffer.Length);

                } while (true);

                writeStream.Close();
            }

            if (File.Exists(localFilePath))
            {
                MessageBox.Show("File downloaded.", "Downloaded successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while downloading file.", "Downloading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            inputStream.Dispose();

            cloudProxy.Close();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 0)
            {
                return;
            }

            string fileName = lvFiles.SelectedItems[0].Text;

            CryptoServiceClient cloudProxy = new CryptoServiceClient();

            bool deleteSuccessfull = cloudProxy.DeleteFile(fileName);

            if (deleteSuccessfull)
            {
                MessageBox.Show("File successfully deleted.", "Delete successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while deleting file.", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cloudProxy.Close();

            showCloudFiles();
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CloudForm_MouseDown(object sender, MouseEventArgs e)
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
