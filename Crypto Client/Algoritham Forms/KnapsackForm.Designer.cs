namespace Crypto_Client
{
    partial class KnapsackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnapsackForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMinv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPublicKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.btnCryptText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCryptedDecryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomKey = new System.Windows.Forms.Button();
            this.txbEnteredText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cxbSaveToCloud = new System.Windows.Forms.CheckBox();
            this.lblFileDecryptedSaved = new System.Windows.Forms.Label();
            this.lblFileCryptedSaved = new System.Windows.Forms.Label();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnCryptFile = new System.Windows.Forms.Button();
            this.lblGenerateFileKey = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnGetFileKey = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCloud = new System.Windows.Forms.Button();
            this.btnFileWatcher = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Lime;
            this.btnBack.Location = new System.Drawing.Point(685, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 24);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(760, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 24);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Knapsack";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbMinv);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbM);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbPublicKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbKey);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.btnDecryptText);
            this.groupBox2.Controls.Add(this.btnCryptText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbCryptedDecryptedText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRandomKey);
            this.groupBox2.Controls.Add(this.txbEnteredText);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(10, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(462, 317);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Crypt/Decrypt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(84, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "M-1:";
            // 
            // txbMinv
            // 
            this.txbMinv.BackColor = System.Drawing.Color.Black;
            this.txbMinv.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinv.ForeColor = System.Drawing.Color.Lime;
            this.txbMinv.Location = new System.Drawing.Point(132, 51);
            this.txbMinv.MaxLength = 99999;
            this.txbMinv.Name = "txbMinv";
            this.txbMinv.ReadOnly = true;
            this.txbMinv.Size = new System.Drawing.Size(41, 20);
            this.txbMinv.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "M:";
            // 
            // txbM
            // 
            this.txbM.BackColor = System.Drawing.Color.Black;
            this.txbM.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbM.ForeColor = System.Drawing.Color.Lime;
            this.txbM.Location = new System.Drawing.Point(37, 51);
            this.txbM.MaxLength = 99999;
            this.txbM.Name = "txbM";
            this.txbM.Size = new System.Drawing.Size(41, 20);
            this.txbM.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "N:";
            // 
            // txbN
            // 
            this.txbN.BackColor = System.Drawing.Color.Black;
            this.txbN.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbN.ForeColor = System.Drawing.Color.Lime;
            this.txbN.Location = new System.Drawing.Point(37, 25);
            this.txbN.MaxLength = 99999;
            this.txbN.Name = "txbN";
            this.txbN.Size = new System.Drawing.Size(41, 20);
            this.txbN.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Public Key:";
            // 
            // txbPublicKey
            // 
            this.txbPublicKey.BackColor = System.Drawing.Color.Black;
            this.txbPublicKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublicKey.ForeColor = System.Drawing.Color.Lime;
            this.txbPublicKey.Location = new System.Drawing.Point(10, 153);
            this.txbPublicKey.MaxLength = 99999;
            this.txbPublicKey.Name = "txbPublicKey";
            this.txbPublicKey.ReadOnly = true;
            this.txbPublicKey.Size = new System.Drawing.Size(166, 20);
            this.txbPublicKey.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Private Key:";
            // 
            // txbKey
            // 
            this.txbKey.BackColor = System.Drawing.Color.Black;
            this.txbKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.ForeColor = System.Drawing.Color.Lime;
            this.txbKey.Location = new System.Drawing.Point(10, 104);
            this.txbKey.MaxLength = 99999;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(166, 20);
            this.txbKey.TabIndex = 21;
            // 
            // btnMove
            // 
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Lime;
            this.btnMove.Location = new System.Drawing.Point(380, 161);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(69, 20);
            this.btnMove.TabIndex = 20;
            this.btnMove.Text = "↑ Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderSize = 2;
            this.btnDecryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptText.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptText.Location = new System.Drawing.Point(10, 272);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(134, 23);
            this.btnDecryptText.TabIndex = 19;
            this.btnDecryptText.Text = "Decrypt Text";
            this.btnDecryptText.UseVisualStyleBackColor = false;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // btnCryptText
            // 
            this.btnCryptText.BackColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderSize = 2;
            this.btnCryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptText.ForeColor = System.Drawing.Color.Black;
            this.btnCryptText.Location = new System.Drawing.Point(10, 229);
            this.btnCryptText.Name = "btnCryptText";
            this.btnCryptText.Size = new System.Drawing.Size(134, 23);
            this.btnCryptText.TabIndex = 18;
            this.btnCryptText.Text = "Crypt Text";
            this.btnCryptText.UseVisualStyleBackColor = false;
            this.btnCryptText.Click += new System.EventHandler(this.btnCryptText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(184, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Crypted/Decrypted text:";
            // 
            // txbCryptedDecryptedText
            // 
            this.txbCryptedDecryptedText.BackColor = System.Drawing.Color.Black;
            this.txbCryptedDecryptedText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCryptedDecryptedText.ForeColor = System.Drawing.Color.Lime;
            this.txbCryptedDecryptedText.Location = new System.Drawing.Point(188, 190);
            this.txbCryptedDecryptedText.Multiline = true;
            this.txbCryptedDecryptedText.Name = "txbCryptedDecryptedText";
            this.txbCryptedDecryptedText.ReadOnly = true;
            this.txbCryptedDecryptedText.Size = new System.Drawing.Size(263, 110);
            this.txbCryptedDecryptedText.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(184, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter text:";
            // 
            // btnRandomKey
            // 
            this.btnRandomKey.BackColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderSize = 2;
            this.btnRandomKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomKey.ForeColor = System.Drawing.Color.Black;
            this.btnRandomKey.Location = new System.Drawing.Point(10, 184);
            this.btnRandomKey.Name = "btnRandomKey";
            this.btnRandomKey.Size = new System.Drawing.Size(134, 23);
            this.btnRandomKey.TabIndex = 12;
            this.btnRandomKey.Text = "Random key";
            this.btnRandomKey.UseVisualStyleBackColor = false;
            this.btnRandomKey.Click += new System.EventHandler(this.btnRandomKey_Click);
            // 
            // txbEnteredText
            // 
            this.txbEnteredText.BackColor = System.Drawing.Color.Black;
            this.txbEnteredText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnteredText.ForeColor = System.Drawing.Color.Lime;
            this.txbEnteredText.Location = new System.Drawing.Point(188, 41);
            this.txbEnteredText.Multiline = true;
            this.txbEnteredText.Name = "txbEnteredText";
            this.txbEnteredText.Size = new System.Drawing.Size(263, 110);
            this.txbEnteredText.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cxbSaveToCloud);
            this.groupBox1.Controls.Add(this.lblFileDecryptedSaved);
            this.groupBox1.Controls.Add(this.lblFileCryptedSaved);
            this.groupBox1.Controls.Add(this.btnDecryptFile);
            this.groupBox1.Controls.Add(this.btnCryptFile);
            this.groupBox1.Controls.Add(this.lblGenerateFileKey);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnGetFileKey);
            this.groupBox1.Controls.Add(this.btnUploadFile);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(486, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(299, 150);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Crypt/Decrypt";
            // 
            // cxbSaveToCloud
            // 
            this.cxbSaveToCloud.AutoSize = true;
            this.cxbSaveToCloud.Location = new System.Drawing.Point(25, 120);
            this.cxbSaveToCloud.Margin = new System.Windows.Forms.Padding(2);
            this.cxbSaveToCloud.Name = "cxbSaveToCloud";
            this.cxbSaveToCloud.Size = new System.Drawing.Size(92, 17);
            this.cxbSaveToCloud.TabIndex = 33;
            this.cxbSaveToCloud.Text = "Save to cloud";
            this.cxbSaveToCloud.UseVisualStyleBackColor = true;
            // 
            // lblFileDecryptedSaved
            // 
            this.lblFileDecryptedSaved.AutoSize = true;
            this.lblFileDecryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDecryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileDecryptedSaved.Location = new System.Drawing.Point(155, 95);
            this.lblFileDecryptedSaved.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileDecryptedSaved.Name = "lblFileDecryptedSaved";
            this.lblFileDecryptedSaved.Size = new System.Drawing.Size(110, 15);
            this.lblFileDecryptedSaved.TabIndex = 32;
            this.lblFileDecryptedSaved.Text = "fileDecryptedSaved";
            this.lblFileDecryptedSaved.Visible = false;
            // 
            // lblFileCryptedSaved
            // 
            this.lblFileCryptedSaved.AutoSize = true;
            this.lblFileCryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileCryptedSaved.Location = new System.Drawing.Point(22, 95);
            this.lblFileCryptedSaved.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileCryptedSaved.Name = "lblFileCryptedSaved";
            this.lblFileCryptedSaved.Size = new System.Drawing.Size(103, 15);
            this.lblFileCryptedSaved.TabIndex = 31;
            this.lblFileCryptedSaved.Text = "fileCryptedSaved";
            this.lblFileCryptedSaved.Visible = false;
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptFile.FlatAppearance.BorderSize = 2;
            this.btnDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptFile.Location = new System.Drawing.Point(158, 69);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(120, 23);
            this.btnDecryptFile.TabIndex = 30;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = false;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnCryptFile
            // 
            this.btnCryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderSize = 2;
            this.btnCryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnCryptFile.Location = new System.Drawing.Point(25, 69);
            this.btnCryptFile.Name = "btnCryptFile";
            this.btnCryptFile.Size = new System.Drawing.Size(120, 23);
            this.btnCryptFile.TabIndex = 29;
            this.btnCryptFile.Text = "Crypt File";
            this.btnCryptFile.UseVisualStyleBackColor = false;
            this.btnCryptFile.Click += new System.EventHandler(this.btnCryptFile_Click);
            // 
            // lblGenerateFileKey
            // 
            this.lblGenerateFileKey.AutoSize = true;
            this.lblGenerateFileKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateFileKey.ForeColor = System.Drawing.Color.Lime;
            this.lblGenerateFileKey.Location = new System.Drawing.Point(155, 44);
            this.lblGenerateFileKey.MaximumSize = new System.Drawing.Size(200, 15);
            this.lblGenerateFileKey.Name = "lblGenerateFileKey";
            this.lblGenerateFileKey.Size = new System.Drawing.Size(47, 15);
            this.lblGenerateFileKey.TabIndex = 26;
            this.lblGenerateFileKey.Text = "fileKey";
            this.lblGenerateFileKey.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Lime;
            this.lblFileName.Location = new System.Drawing.Point(22, 44);
            this.lblFileName.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(58, 15);
            this.lblFileName.TabIndex = 25;
            this.lblFileName.Text = "fileName";
            this.lblFileName.Visible = false;
            // 
            // btnGetFileKey
            // 
            this.btnGetFileKey.BackColor = System.Drawing.Color.Lime;
            this.btnGetFileKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGetFileKey.FlatAppearance.BorderSize = 2;
            this.btnGetFileKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetFileKey.ForeColor = System.Drawing.Color.Black;
            this.btnGetFileKey.Location = new System.Drawing.Point(158, 18);
            this.btnGetFileKey.Name = "btnGetFileKey";
            this.btnGetFileKey.Size = new System.Drawing.Size(120, 23);
            this.btnGetFileKey.TabIndex = 24;
            this.btnGetFileKey.Text = "Generate File Key";
            this.btnGetFileKey.UseVisualStyleBackColor = false;
            this.btnGetFileKey.Click += new System.EventHandler(this.btnGetFileKey_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderSize = 2;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.ForeColor = System.Drawing.Color.Black;
            this.btnUploadFile.Location = new System.Drawing.Point(25, 18);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(120, 23);
            this.btnUploadFile.TabIndex = 23;
            this.btnUploadFile.Text = "Select File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloud);
            this.groupBox3.Controls.Add(this.btnFileWatcher);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(486, 226);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(300, 88);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Watcher / Cloud";
            // 
            // btnCloud
            // 
            this.btnCloud.BackColor = System.Drawing.Color.Lime;
            this.btnCloud.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCloud.FlatAppearance.BorderSize = 2;
            this.btnCloud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloud.ForeColor = System.Drawing.Color.Black;
            this.btnCloud.Location = new System.Drawing.Point(158, 37);
            this.btnCloud.Name = "btnCloud";
            this.btnCloud.Size = new System.Drawing.Size(120, 23);
            this.btnCloud.TabIndex = 38;
            this.btnCloud.Text = "Cloud";
            this.btnCloud.UseVisualStyleBackColor = false;
            this.btnCloud.Click += new System.EventHandler(this.btnCloud_Click);
            // 
            // btnFileWatcher
            // 
            this.btnFileWatcher.BackColor = System.Drawing.Color.Lime;
            this.btnFileWatcher.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnFileWatcher.FlatAppearance.BorderSize = 2;
            this.btnFileWatcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFileWatcher.ForeColor = System.Drawing.Color.Black;
            this.btnFileWatcher.Location = new System.Drawing.Point(24, 37);
            this.btnFileWatcher.Name = "btnFileWatcher";
            this.btnFileWatcher.Size = new System.Drawing.Size(120, 23);
            this.btnFileWatcher.TabIndex = 37;
            this.btnFileWatcher.Text = "File Watcher";
            this.btnFileWatcher.UseVisualStyleBackColor = false;
            this.btnFileWatcher.Click += new System.EventHandler(this.btnFileWatcher_Click);
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "ofdUploadFile";
            // 
            // KnapsackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnapsackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnapsackForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KnapsackForm_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDecryptText;
        private System.Windows.Forms.Button btnCryptText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCryptedDecryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomKey;
        private System.Windows.Forms.TextBox txbEnteredText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPublicKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMinv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cxbSaveToCloud;
        private System.Windows.Forms.Label lblFileDecryptedSaved;
        private System.Windows.Forms.Label lblFileCryptedSaved;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnCryptFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCloud;
        private System.Windows.Forms.Button btnFileWatcher;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Label lblGenerateFileKey;
        private System.Windows.Forms.Button btnGetFileKey;
    }
}