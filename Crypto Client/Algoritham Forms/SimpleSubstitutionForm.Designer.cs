namespace Crypto_Client
{
    partial class SimpleSubstitutionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSubstitutionForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbEnteredText = new System.Windows.Forms.TextBox();
            this.btnRandomKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCryptedDecryptedText = new System.Windows.Forms.TextBox();
            this.btnCryptText = new System.Windows.Forms.Button();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.btnGetFileKey = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblGenerateFileKey = new System.Windows.Forms.Label();
            this.btnCryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.lblFileCryptedSaved = new System.Windows.Forms.Label();
            this.lblFileDecryptedSaved = new System.Windows.Forms.Label();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFileWatcher = new System.Windows.Forms.Button();
            this.btnCloud = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cxbSaveToCloud = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simple Substitution";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(1013, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Lime;
            this.btnBack.Location = new System.Drawing.Point(913, 1);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbEnteredText
            // 
            this.txbEnteredText.BackColor = System.Drawing.Color.Black;
            this.txbEnteredText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnteredText.ForeColor = System.Drawing.Color.Lime;
            this.txbEnteredText.Location = new System.Drawing.Point(251, 50);
            this.txbEnteredText.Margin = new System.Windows.Forms.Padding(4);
            this.txbEnteredText.Multiline = true;
            this.txbEnteredText.Name = "txbEnteredText";
            this.txbEnteredText.Size = new System.Drawing.Size(349, 134);
            this.txbEnteredText.TabIndex = 10;
            this.txbEnteredText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEnteredText_KeyPress);
            // 
            // btnRandomKey
            // 
            this.btnRandomKey.BackColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderSize = 2;
            this.btnRandomKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomKey.ForeColor = System.Drawing.Color.Black;
            this.btnRandomKey.Location = new System.Drawing.Point(13, 139);
            this.btnRandomKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomKey.Name = "btnRandomKey";
            this.btnRandomKey.Size = new System.Drawing.Size(179, 28);
            this.btnRandomKey.TabIndex = 12;
            this.btnRandomKey.Text = "Random key";
            this.btnRandomKey.UseVisualStyleBackColor = false;
            this.btnRandomKey.Click += new System.EventHandler(this.btnRandomKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(246, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(246, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Crypted/Decrypted text:";
            // 
            // txbCryptedDecryptedText
            // 
            this.txbCryptedDecryptedText.BackColor = System.Drawing.Color.Black;
            this.txbCryptedDecryptedText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCryptedDecryptedText.ForeColor = System.Drawing.Color.Lime;
            this.txbCryptedDecryptedText.Location = new System.Drawing.Point(251, 234);
            this.txbCryptedDecryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.txbCryptedDecryptedText.Multiline = true;
            this.txbCryptedDecryptedText.Name = "txbCryptedDecryptedText";
            this.txbCryptedDecryptedText.ReadOnly = true;
            this.txbCryptedDecryptedText.Size = new System.Drawing.Size(349, 134);
            this.txbCryptedDecryptedText.TabIndex = 14;
            // 
            // btnCryptText
            // 
            this.btnCryptText.BackColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderSize = 2;
            this.btnCryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptText.ForeColor = System.Drawing.Color.Black;
            this.btnCryptText.Location = new System.Drawing.Point(13, 282);
            this.btnCryptText.Margin = new System.Windows.Forms.Padding(4);
            this.btnCryptText.Name = "btnCryptText";
            this.btnCryptText.Size = new System.Drawing.Size(179, 28);
            this.btnCryptText.TabIndex = 18;
            this.btnCryptText.Text = "Crypt Text";
            this.btnCryptText.UseVisualStyleBackColor = false;
            this.btnCryptText.Click += new System.EventHandler(this.btnCryptText_Click);
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderSize = 2;
            this.btnDecryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptText.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptText.Location = new System.Drawing.Point(13, 335);
            this.btnDecryptText.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(179, 28);
            this.btnDecryptText.TabIndex = 19;
            this.btnDecryptText.Text = "Decrypt Text";
            this.btnDecryptText.UseVisualStyleBackColor = false;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // btnMove
            // 
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Lime;
            this.btnMove.Location = new System.Drawing.Point(506, 198);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(92, 25);
            this.btnMove.TabIndex = 20;
            this.btnMove.Text = "↑ Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Crypt Alphabet:";
            // 
            // txbKey
            // 
            this.txbKey.BackColor = System.Drawing.Color.Black;
            this.txbKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.ForeColor = System.Drawing.Color.Lime;
            this.txbKey.Location = new System.Drawing.Point(13, 104);
            this.txbKey.Margin = new System.Windows.Forms.Padding(4);
            this.txbKey.MaxLength = 26;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(220, 23);
            this.txbKey.TabIndex = 21;
            this.txbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderSize = 2;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.ForeColor = System.Drawing.Color.Black;
            this.btnUploadFile.Location = new System.Drawing.Point(33, 22);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(160, 28);
            this.btnUploadFile.TabIndex = 23;
            this.btnUploadFile.Text = "Select File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "ofdUploadFile";
            // 
            // btnGetFileKey
            // 
            this.btnGetFileKey.BackColor = System.Drawing.Color.Lime;
            this.btnGetFileKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGetFileKey.FlatAppearance.BorderSize = 2;
            this.btnGetFileKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetFileKey.ForeColor = System.Drawing.Color.Black;
            this.btnGetFileKey.Location = new System.Drawing.Point(211, 22);
            this.btnGetFileKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFileKey.Name = "btnGetFileKey";
            this.btnGetFileKey.Size = new System.Drawing.Size(160, 28);
            this.btnGetFileKey.TabIndex = 24;
            this.btnGetFileKey.Text = "Generate File Key";
            this.btnGetFileKey.UseVisualStyleBackColor = false;
            this.btnGetFileKey.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Lime;
            this.lblFileName.Location = new System.Drawing.Point(29, 54);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.MaximumSize = new System.Drawing.Size(147, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(68, 18);
            this.lblFileName.TabIndex = 25;
            this.lblFileName.Text = "fileName";
            this.lblFileName.Visible = false;
            // 
            // lblGenerateFileKey
            // 
            this.lblGenerateFileKey.AutoSize = true;
            this.lblGenerateFileKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateFileKey.ForeColor = System.Drawing.Color.Lime;
            this.lblGenerateFileKey.Location = new System.Drawing.Point(207, 54);
            this.lblGenerateFileKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerateFileKey.MaximumSize = new System.Drawing.Size(267, 18);
            this.lblGenerateFileKey.Name = "lblGenerateFileKey";
            this.lblGenerateFileKey.Size = new System.Drawing.Size(54, 18);
            this.lblGenerateFileKey.TabIndex = 26;
            this.lblGenerateFileKey.Text = "fileKey";
            this.lblGenerateFileKey.Visible = false;
            // 
            // btnCryptFile
            // 
            this.btnCryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderSize = 2;
            this.btnCryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnCryptFile.Location = new System.Drawing.Point(33, 85);
            this.btnCryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCryptFile.Name = "btnCryptFile";
            this.btnCryptFile.Size = new System.Drawing.Size(160, 28);
            this.btnCryptFile.TabIndex = 29;
            this.btnCryptFile.Text = "Crypt File";
            this.btnCryptFile.UseVisualStyleBackColor = false;
            this.btnCryptFile.Click += new System.EventHandler(this.btnCryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptFile.FlatAppearance.BorderSize = 2;
            this.btnDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptFile.Location = new System.Drawing.Point(211, 85);
            this.btnDecryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(160, 28);
            this.btnDecryptFile.TabIndex = 30;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = false;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // lblFileCryptedSaved
            // 
            this.lblFileCryptedSaved.AutoSize = true;
            this.lblFileCryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileCryptedSaved.Location = new System.Drawing.Point(29, 120);
            this.lblFileCryptedSaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileCryptedSaved.MaximumSize = new System.Drawing.Size(147, 18);
            this.lblFileCryptedSaved.Name = "lblFileCryptedSaved";
            this.lblFileCryptedSaved.Size = new System.Drawing.Size(120, 18);
            this.lblFileCryptedSaved.TabIndex = 31;
            this.lblFileCryptedSaved.Text = "fileCryptedSaved";
            this.lblFileCryptedSaved.Visible = false;
            // 
            // lblFileDecryptedSaved
            // 
            this.lblFileDecryptedSaved.AutoSize = true;
            this.lblFileDecryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDecryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileDecryptedSaved.Location = new System.Drawing.Point(207, 117);
            this.lblFileDecryptedSaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileDecryptedSaved.MaximumSize = new System.Drawing.Size(147, 18);
            this.lblFileDecryptedSaved.Name = "lblFileDecryptedSaved";
            this.lblFileDecryptedSaved.Size = new System.Drawing.Size(137, 18);
            this.lblFileDecryptedSaved.TabIndex = 32;
            this.lblFileDecryptedSaved.Text = "fileDecryptedSaved";
            this.lblFileDecryptedSaved.Visible = false;
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
            this.groupBox1.Location = new System.Drawing.Point(648, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 184);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Crypt/Decrypt";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(14, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 390);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Crypt/Decrypt";
            // 
            // btnFileWatcher
            // 
            this.btnFileWatcher.BackColor = System.Drawing.Color.Lime;
            this.btnFileWatcher.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnFileWatcher.FlatAppearance.BorderSize = 2;
            this.btnFileWatcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFileWatcher.ForeColor = System.Drawing.Color.Black;
            this.btnFileWatcher.Location = new System.Drawing.Point(32, 45);
            this.btnFileWatcher.Margin = new System.Windows.Forms.Padding(4);
            this.btnFileWatcher.Name = "btnFileWatcher";
            this.btnFileWatcher.Size = new System.Drawing.Size(160, 28);
            this.btnFileWatcher.TabIndex = 37;
            this.btnFileWatcher.Text = "File Watcher";
            this.btnFileWatcher.UseVisualStyleBackColor = false;
            this.btnFileWatcher.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnCloud
            // 
            this.btnCloud.BackColor = System.Drawing.Color.Lime;
            this.btnCloud.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCloud.FlatAppearance.BorderSize = 2;
            this.btnCloud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloud.ForeColor = System.Drawing.Color.Black;
            this.btnCloud.Location = new System.Drawing.Point(211, 45);
            this.btnCloud.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloud.Name = "btnCloud";
            this.btnCloud.Size = new System.Drawing.Size(160, 28);
            this.btnCloud.TabIndex = 38;
            this.btnCloud.Text = "Cloud";
            this.btnCloud.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloud);
            this.groupBox3.Controls.Add(this.btnFileWatcher);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(648, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 108);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Watcher / Cloud";
            // 
            // cxbSaveToCloud
            // 
            this.cxbSaveToCloud.AutoSize = true;
            this.cxbSaveToCloud.Location = new System.Drawing.Point(33, 148);
            this.cxbSaveToCloud.Name = "cxbSaveToCloud";
            this.cxbSaveToCloud.Size = new System.Drawing.Size(116, 21);
            this.cxbSaveToCloud.TabIndex = 33;
            this.cxbSaveToCloud.Text = "Save to cloud";
            this.cxbSaveToCloud.UseVisualStyleBackColor = true;
            // 
            // SimpleSubstitutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1055, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleSubstitutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleSubstitutionForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimpleSubstitutionForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbEnteredText;
        private System.Windows.Forms.Button btnRandomKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCryptedDecryptedText;
        private System.Windows.Forms.Button btnCryptText;
        private System.Windows.Forms.Button btnDecryptText;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Button btnGetFileKey;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblGenerateFileKey;
        private System.Windows.Forms.Button btnCryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Label lblFileCryptedSaved;
        private System.Windows.Forms.Label lblFileDecryptedSaved;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileWatcher;
        private System.Windows.Forms.Button btnCloud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cxbSaveToCloud;
    }
}