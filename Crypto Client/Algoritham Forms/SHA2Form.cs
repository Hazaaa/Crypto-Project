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
using Crypto_Client.Other_Forms;
using System.IO;
using Crypto_Client.CryptoService;

namespace Crypto_Client.Algoritham_Forms
{
    public partial class SHA2Form : Form
    {
        #region Attributes

        private string fileForHashPath = "";
        private string fileForHashName = "";
        private string fileExtension = "";

        public SHA2Algorithm sha2Algorithm;

        public SHA2Form()
        {
            sha2Algorithm = new SHA2Algorithm();
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
            if (txbEnteredText.Text.Equals(""))
            {
                return;
            }

            byte[] textToCrypt = Encoding.Default.GetBytes(txbEnteredText.Text);
            byte[] hash = sha2Algorithm.Crypt(textToCrypt);

            string hashStr = "";

            for (int i = 0; i < hash.Length; i++)
            {
                hashStr += string.Format("{0:X2}", hash[i]);
            }
            txbCryptedDecryptedText.Text = hashStr;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            lblFileName.Visible = false;
            lblFileCryptedSaved.Visible = false;

            if (ofdUploadFile.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Visible = true;
                lblFileName.Text = "File selected!";
                fileForHashPath = ofdUploadFile.FileName;
                fileExtension = Path.GetExtension(ofdUploadFile.FileName);

                string[] tmpPath = fileForHashPath.Split('\\');
                string[] tmpName = tmpPath.Last().Split('.');
                fileForHashName = tmpName.First();
            }
        }

        private void btnCryptFile_Click(object sender, EventArgs e)
        {
            if (fileForHashPath.Equals(""))
            {
                MessageBox.Show("File isn't selected!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFileCryptedSaved.Visible = false;
                return;
            }

            byte[] file = null;

            file = File.ReadAllBytes(fileForHashPath);

            byte[] cryptedFile = sha2Algorithm.Crypt(file);

            string hashStr = "";

            for (int i = 0; i < 32; i++)
            {
                hashStr += string.Format("{0:X2}", cryptedFile[i]);
            }

            File.WriteAllText(@".\\Crypted\\" + fileForHashName + fileExtension, hashStr);

            if (cxbSaveToCloud.Checked)
            {
                var cloudProxy = new CryptoServiceClient();

                using (var stream = new FileStream(@".\\Crypted\\" + fileForHashName + fileExtension, FileMode.Open, FileAccess.Read))
                {
                    bool resultOfUpload = cloudProxy.UploadFile(fileForHashName + fileExtension, stream);

                    if (resultOfUpload == true)
                        MessageBox.Show("File uploaded to cloud!", "Successfull upload!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("There was error while trying to upload file!", "Error while uploading!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cloudProxy.Close();
            }

            lblFileCryptedSaved.Visible = true;
            lblFileCryptedSaved.Text = "File hashed!";
        }

        private void btnFileWatcher_Click(object sender, EventArgs e)
        {
            WatcherForm wf = new WatcherForm(sha2Algorithm);
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

        private void SHA2Form_MouseDown(object sender, MouseEventArgs e)
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
