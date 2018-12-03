using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Crypto_Lib;
using Crypto_Client.Other_Forms;

namespace Crypto_Client
{
    public partial class SimpleSubstitutionForm : Form
    {
        private CryptoService.CryptoServiceClient service;
        private SimpleSubstitutionAlgorithm simpleSubstitutionAlgorithm;
        private string fileForCryptPath = "";
        private string fileForCryptName = "";
        private string fileExtension = "";
        private string generated256Key = "";
        private string randomed256Key = "";

        public SimpleSubstitutionForm()
        {
            InitializeComponent();
            service = new CryptoService.CryptoServiceClient();
            simpleSubstitutionAlgorithm = new SimpleSubstitutionAlgorithm();
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SimpleSubstitutionForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

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

        private void btnRandomKey_Click(object sender, EventArgs e)
        {
            txbKey.Text = Encoding.ASCII.GetString(simpleSubstitutionAlgorithm.GenerateRandomKey());
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
            byte[] textToCrypt = Encoding.ASCII.GetBytes(txbEnteredText.Text);
            byte[] key = Encoding.ASCII.GetBytes(txbKey.Text);
            simpleSubstitutionAlgorithm.SetKey(key);
            byte[] cryptedText = simpleSubstitutionAlgorithm.Crypt(textToCrypt);
            txbCryptedDecryptedText.Text = Encoding.ASCII.GetString(cryptedText);
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if(txbKey.Text == "")
            {
                MessageBox.Show("Key box cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txbEnteredText.Text == "")
            {
                return;
            }

            byte[] textToDecrypt = Encoding.ASCII.GetBytes(txbEnteredText.Text);
            byte[] key = Encoding.ASCII.GetBytes(txbKey.Text);
            simpleSubstitutionAlgorithm.SetKey(key);
            byte[] cryptedText = simpleSubstitutionAlgorithm.Decrypt(textToDecrypt);
            txbCryptedDecryptedText.Text = Encoding.ASCII.GetString(cryptedText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbEnteredText.Text = txbCryptedDecryptedText.Text;
            txbCryptedDecryptedText.Text = "";
        }

        private void txbEnteredText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string alphabet256 = "";
            for (int i = 0; i < 255; i++)
            {
                alphabet256  += (char)i;
            }

            generated256Key = alphabet256;

            Random random = new Random();
            randomed256Key = new string(alphabet256.ToCharArray().OrderBy(x => random.Next()).ToArray());
            

            lblGenerateFileKey.Visible = true;
            if (!generated256Key.Equals(""))
            {
                lblGenerateFileKey.Text = "Key generated!";
            }
            else
            {
                lblGenerateFileKey.Text = "Key not generated!";
            }
        }

        private void btnCryptFile_Click(object sender, EventArgs e)
        {
            if(fileForCryptPath.Equals(""))
            {
                MessageBox.Show("File isn't selected!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFileCryptedSaved.Visible = false;
                return;
            }

            byte[] file = null;
            byte[] fileKey = Encoding.UTF8.GetBytes(generated256Key);
            byte[] randomKey = Encoding.UTF8.GetBytes(randomed256Key);

            if(generated256Key.Equals("") || randomed256Key.Equals(""))
            {
                MessageBox.Show("Key isn't generated", "Missing key!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            file = File.ReadAllBytes(fileForCryptPath);

            Dictionary<string, byte[]> properties = new Dictionary<string,byte[]>();
            properties.Add("alphabet256", fileKey);
            properties.Add("alphabet256Key", randomKey);

            simpleSubstitutionAlgorithm.SetAlgorithmProperties(properties);
            byte[] cryptedFile = simpleSubstitutionAlgorithm.Crypt(file);
            File.WriteAllBytes(@".\\Crypted\\" + fileForCryptName + fileExtension, cryptedFile);

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
            byte[] fileKey = Encoding.UTF8.GetBytes(generated256Key);
            byte[] randomKey = Encoding.UTF8.GetBytes(randomed256Key);

            if (generated256Key.Equals("") || randomed256Key.Equals(""))
            {
                MessageBox.Show("Key isn't generated", "Missing key!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            file = File.ReadAllBytes(@".\\Crypted\\" + fileForCryptName + fileExtension);

            Dictionary<string, byte[]> properties = new Dictionary<string, byte[]>();
            properties.Add("alphabet256", fileKey);
            properties.Add("alphabet256Key", randomKey);

            simpleSubstitutionAlgorithm.SetAlgorithmProperties(properties);
            byte[] decryptedFile = simpleSubstitutionAlgorithm.Decrypt(file);
            File.WriteAllBytes(@".\\Decrypted\\" + fileForCryptName + fileExtension, decryptedFile);

            lblFileDecryptedSaved.Visible = true;
            lblFileDecryptedSaved.Text = "File decrypted!";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            using (WatcherForm wf = new WatcherForm(simpleSubstitutionAlgorithm))
            {
                wf.ShowDialog();
            }
        }
    }
}
