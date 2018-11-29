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

namespace Crypto_Client
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Moving form without border

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btnSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            SimpleSubstitutionForm simpleForm = new SimpleSubstitutionForm();
            simpleForm.ShowDialog();
            this.Close();
        }

        private void btnKnapsack_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnapsackForm knapsackForm = new KnapsackForm();
            knapsackForm.ShowDialog();
            this.Close();
        }
    }
}
