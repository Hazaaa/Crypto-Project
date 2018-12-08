using Crypto_Client.CryptoService;
using Crypto_Client.Other_Forms;
using Crypto_Lib;
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

namespace Crypto_Client.Algoritham_Forms
{
    public partial class XXTEAForm : Form
    {

        #region Attributes

        private XXTEAAlgorithm xxtea;
        private string fileForCryptPath = "";
        private string fileForCryptName = "";
        private string fileExtension = "";

        public XXTEAForm()
        {
            xxtea = new XXTEAAlgorithm();
            InitializeComponent();
        }

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnCryptText_Click(object sender, EventArgs e)
        {
            if (txbKey.Text == "")
            {
                MessageBox.Show("Key box cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbEnteredText.Text == "")
            {
                return;
            }

            byte[] textToCrypt = Encoding.Default.GetBytes(txbEnteredText.Text);
            byte[] key = Encoding.Default.GetBytes(txbKey.Text);
            xxtea.SetKey(key);
            byte[] cryptedText = xxtea.Crypt(textToCrypt);
            txbCryptedDecryptedText.Text = Encoding.Default.GetString(cryptedText);
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if (txbKey.Text == "")
            {
                MessageBox.Show("Enter text to decrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbEnteredText.Text == "")
            {
                return;
            }

            byte[] textToDecrypt = Encoding.Default.GetBytes(txbEnteredText.Text);
            byte[] key = Encoding.Default.GetBytes(txbKey.Text);
            xxtea.SetKey(key);
            byte[] cryptedText = xxtea.Decrypt(textToDecrypt);
            txbCryptedDecryptedText.Text = Encoding.Default.GetString(cryptedText);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            txbEnteredText.Text = txbCryptedDecryptedText.Text;
            txbCryptedDecryptedText.Text = "";
        }

        private void btnRandomKey_Click(object sender, EventArgs e)
        {
            txbKey.Text = Encoding.UTF8.GetString(xxtea.GenerateRandomKey());
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            lblFileName.Visible = false;
            lblFileCryptedSaved.Visible = false;
            lblFileDecryptedSaved.Visible = false;

            if (ofdUploadFile.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Visible = true;
                lblFileName.Text = "File selected!";
                fileForCryptPath = ofdUploadFile.FileName;
                fileExtension = Path.GetExtension(ofdUploadFile.FileName);

                string[] tmpPath = fileForCryptPath.Split('\\');
                string[] tmpName = tmpPath.Last().Split('.');
                fileForCryptName = tmpName.First();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbFileKey.Text = Encoding.UTF8.GetString(xxtea.GenerateRandomKey());
        }

        private void btnCryptFile_Click(object sender, EventArgs e)
        {
            if (fileForCryptPath.Equals(""))
            {
                MessageBox.Show("File isn't selected!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFileCryptedSaved.Visible = false;
                return;
            }

            byte[] file = null;

            if (txbFileKey.Text.Equals(""))
            {
                MessageBox.Show("Key isn't generated", "Missing key!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            file = File.ReadAllBytes(fileForCryptPath);

            byte[] key = Encoding.UTF8.GetBytes(txbFileKey.Text);
            xxtea.SetKey(key);

            byte[] cryptedFile = xxtea.Crypt(file);
            File.WriteAllBytes(@".\\Crypted\\" + fileForCryptName + fileExtension, cryptedFile);

            if (cxbSaveToCloud.Checked)
            {
                var cloudProxy = new CryptoServiceClient();

                using (var stream = new FileStream(@".\\Crypted\\" + fileForCryptName + fileExtension, FileMode.Open, FileAccess.Read))
                {
                    bool resultOfUpload = cloudProxy.UploadFile(fileForCryptName + fileExtension, stream);

                    if (resultOfUpload == true)
                        MessageBox.Show("File uploaded to cloud!", "Successfull upload!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("There was error while trying to upload file!", "Error while uploading!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cloudProxy.Close();
            }

            lblFileCryptedSaved.Visible = true;
            lblFileCryptedSaved.Text = "File crypted!";
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (fileForCryptPath.Equals(""))
            {
                MessageBox.Show("File isn't selected!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFileCryptedSaved.Visible = false;
                return;
            }

            byte[] file = null;

            if (txbFileKey.Text.Equals(""))
            {
                MessageBox.Show("Key isn't generated", "Missing key!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            file = File.ReadAllBytes(@".\\Crypted\\" + fileForCryptName + fileExtension);
            byte[] key = Encoding.UTF8.GetBytes(txbFileKey.Text);
            xxtea.SetKey(key);

            byte[] decryptedFile = xxtea.Decrypt(file);
            File.WriteAllBytes(@".\\Decrypted\\" + fileForCryptName + fileExtension, decryptedFile);

            lblFileDecryptedSaved.Visible = true;
            lblFileDecryptedSaved.Text = "File decrypted!";
        }

        private void btnFileWatcher_Click(object sender, EventArgs e)
        {
            WatcherForm wf = new WatcherForm(xxtea);
            wf.Show();
        }

        private void btnCloud_Click(object sender, EventArgs e)
        {
            CloudForm cf = new CloudForm();
            cf.Show();
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void XXTEAForm_MouseDown(object sender, MouseEventArgs e)
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
