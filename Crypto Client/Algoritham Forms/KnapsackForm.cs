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

namespace Crypto_Client
{
    public partial class KnapsackForm : Form
    {
        #region Attributes

        private KnapsackAlgorithm knapsackAlgorithm;
        private Dictionary<string, byte[]> specs;
        private uint n;
        private uint m;
        private uint invM;
        private uint[] privateKey;
        private string fileForCryptPath = "";
        private string fileForCryptName = "";
        private string fileExtension = "";

        public KnapsackForm()
        {
            knapsackAlgorithm = new KnapsackAlgorithm();
            specs = new Dictionary<string, byte[]>();
            InitializeComponent();
        }

        #endregion

        #region Events

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCryptText_Click(object sender, EventArgs e)
        {
            if (txbN.Text.Equals(""))
            {
                MessageBox.Show("N can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbM.Text.Equals(""))
            {
                MessageBox.Show("M can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbEnteredText.Text.Equals(""))
            {
                MessageBox.Show("You have to enter text to crypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!knapsackAlgorithm.SetKey(privateKey.SelectMany(BitConverter.GetBytes).ToArray()))
            {
                MessageBox.Show("Private key isn't super increasing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!knapsackAlgorithm.SetAlgorithmProperties(specs))
            {
                MessageBox.Show("Invalid properties!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] textToCrypt = Encoding.ASCII.GetBytes(txbEnteredText.Text);
            byte[] cryptedText = knapsackAlgorithm.Crypt(textToCrypt);
            txbCryptedDecryptedText.Text = Encoding.ASCII.GetString(cryptedText);
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if (txbN.Text.Equals(""))
            {
                MessageBox.Show("N can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbM.Text.Equals(""))
            {
                MessageBox.Show("M can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbEnteredText.Text.Equals(""))
            {
                MessageBox.Show("You have to enter text to crypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!knapsackAlgorithm.SetKey(privateKey.SelectMany(BitConverter.GetBytes).ToArray()))
            {
                MessageBox.Show("Private key isn't super increasing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!knapsackAlgorithm.SetAlgorithmProperties(specs))
            {
                MessageBox.Show("Invalid properties!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] textToDecrypt = Encoding.ASCII.GetBytes(txbEnteredText.Text);
            byte[] decryptedText = knapsackAlgorithm.Decrypt(textToDecrypt);
            txbCryptedDecryptedText.Text = Encoding.ASCII.GetString(decryptedText);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            txbEnteredText.Text = txbCryptedDecryptedText.Text;
            txbCryptedDecryptedText.Text = "";
        }

        private void btnRandomKey_Click(object sender, EventArgs e)
        {
            if (txbN.Text.Equals(""))
            {
                MessageBox.Show("N can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txbM.Text.Equals(""))
            {
                MessageBox.Show("M can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m = UInt32.Parse(txbM.Text);
            n = UInt32.Parse(txbN.Text);

            invM = (n / m + 1);
            txbMinv.Text = invM.ToString();

            privateKey = GeneratePrivateKey(n);
            uint[] publicKey = CalculatePublicKey(privateKey, m, n);


            txbKey.Text = string.Join(", ", privateKey.Select(x => x.ToString()).ToArray());
            txbPublicKey.Text = string.Join(", ", publicKey.Select(x => x.ToString()).ToArray());
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            lblGenerateFileKey.Visible = false;
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

        private void btnGetFileKey_Click(object sender, EventArgs e)
        {
            lblGenerateFileKey.Visible = true;
            lblGenerateFileKey.Text = "Key generated!";
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

            file = File.ReadAllBytes(fileForCryptPath);

            byte[] cryptedFile = knapsackAlgorithm.Crypt(file);
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

            file = File.ReadAllBytes(@".\\Crypted\\" + fileForCryptName + fileExtension);

            byte[] decryptedFile = knapsackAlgorithm.Decrypt(file);
            File.WriteAllBytes(@".\\Decrypted\\" + fileForCryptName + fileExtension, decryptedFile);

            lblFileDecryptedSaved.Visible = true;
            lblFileDecryptedSaved.Text = "File decrypted!";
        }

        private void btnCloud_Click(object sender, EventArgs e)
        {
            CloudForm cf = new CloudForm();
            cf.Show();
        }

        private void btnFileWatcher_Click(object sender, EventArgs e)
        {
            WatcherForm wf = new WatcherForm(knapsackAlgorithm);
            wf.Show();
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void KnapsackForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        #endregion

        #region Help Functions

        private uint[] GeneratePrivateKey(uint N)
        {
            uint[] temp = new uint[8];
            var sum = N;
            for (int i = 8 - 1; i >= 0; i--)
            {
                sum -= 1;
                sum /= 2;
                temp[i] = sum;
            }

            return temp;
        }

        private uint[] CalculatePublicKey(uint[] privateKey, uint M, uint N)
        {
            uint[] temp = new uint[8];
            for (int i = 0; i < 8; i++)
                temp[i] = (privateKey[i] * M) % N;

            return temp;
        }

        #endregion
    }
}
