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
            this.cxbFileWatcher = new System.Windows.Forms.CheckBox();
            this.txbFileWatcher = new System.Windows.Forms.TextBox();
            this.btnCryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.lblFileCryptedSaved = new System.Windows.Forms.Label();
            this.lblFileDecryptedSaved = new System.Windows.Forms.Label();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simple Substitution";
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
            this.btnBack.Location = new System.Drawing.Point(685, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 24);
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
            this.txbEnteredText.Location = new System.Drawing.Point(235, 54);
            this.txbEnteredText.Multiline = true;
            this.txbEnteredText.Name = "txbEnteredText";
            this.txbEnteredText.Size = new System.Drawing.Size(263, 110);
            this.txbEnteredText.TabIndex = 10;
            this.txbEnteredText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEnteredText_KeyPress);
            // 
            // btnRandomKey
            // 
            this.btnRandomKey.BackColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderSize = 2;
            this.btnRandomKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomKey.Location = new System.Drawing.Point(24, 129);
            this.btnRandomKey.Name = "btnRandomKey";
            this.btnRandomKey.Size = new System.Drawing.Size(87, 23);
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
            this.label1.Location = new System.Drawing.Point(231, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(231, 180);
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
            this.txbCryptedDecryptedText.Location = new System.Drawing.Point(235, 203);
            this.txbCryptedDecryptedText.Multiline = true;
            this.txbCryptedDecryptedText.Name = "txbCryptedDecryptedText";
            this.txbCryptedDecryptedText.ReadOnly = true;
            this.txbCryptedDecryptedText.Size = new System.Drawing.Size(263, 110);
            this.txbCryptedDecryptedText.TabIndex = 14;
            // 
            // btnCryptText
            // 
            this.btnCryptText.BackColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderSize = 2;
            this.btnCryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptText.Location = new System.Drawing.Point(24, 203);
            this.btnCryptText.Name = "btnCryptText";
            this.btnCryptText.Size = new System.Drawing.Size(87, 23);
            this.btnCryptText.TabIndex = 18;
            this.btnCryptText.Text = "Crypt";
            this.btnCryptText.UseVisualStyleBackColor = false;
            this.btnCryptText.Click += new System.EventHandler(this.btnCryptText_Click);
            // 
            // btnDecryptText
            // 
            this.btnDecryptText.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptText.FlatAppearance.BorderSize = 2;
            this.btnDecryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptText.Location = new System.Drawing.Point(24, 246);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(87, 23);
            this.btnDecryptText.TabIndex = 19;
            this.btnDecryptText.Text = "Decrypt";
            this.btnDecryptText.UseVisualStyleBackColor = false;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);
            // 
            // btnMove
            // 
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Lime;
            this.btnMove.Location = new System.Drawing.Point(429, 177);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(69, 20);
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
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Crypt Alphabet:";
            // 
            // txbKey
            // 
            this.txbKey.BackColor = System.Drawing.Color.Black;
            this.txbKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.ForeColor = System.Drawing.Color.Lime;
            this.txbKey.Location = new System.Drawing.Point(24, 101);
            this.txbKey.MaxLength = 26;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(166, 20);
            this.txbKey.TabIndex = 21;
            this.txbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUploadFile.FlatAppearance.BorderSize = 2;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Location = new System.Drawing.Point(526, 54);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(120, 23);
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
            this.btnGetFileKey.Location = new System.Drawing.Point(659, 54);
            this.btnGetFileKey.Name = "btnGetFileKey";
            this.btnGetFileKey.Size = new System.Drawing.Size(120, 23);
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
            this.lblFileName.Location = new System.Drawing.Point(523, 80);
            this.lblFileName.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(58, 15);
            this.lblFileName.TabIndex = 25;
            this.lblFileName.Text = "fileName";
            this.lblFileName.Visible = false;
            // 
            // lblGenerateFileKey
            // 
            this.lblGenerateFileKey.AutoSize = true;
            this.lblGenerateFileKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateFileKey.ForeColor = System.Drawing.Color.Lime;
            this.lblGenerateFileKey.Location = new System.Drawing.Point(656, 80);
            this.lblGenerateFileKey.MaximumSize = new System.Drawing.Size(200, 15);
            this.lblGenerateFileKey.Name = "lblGenerateFileKey";
            this.lblGenerateFileKey.Size = new System.Drawing.Size(47, 15);
            this.lblGenerateFileKey.TabIndex = 26;
            this.lblGenerateFileKey.Text = "fileKey";
            this.lblGenerateFileKey.Visible = false;
            // 
            // cxbFileWatcher
            // 
            this.cxbFileWatcher.AutoSize = true;
            this.cxbFileWatcher.ForeColor = System.Drawing.Color.Lime;
            this.cxbFileWatcher.Location = new System.Drawing.Point(526, 157);
            this.cxbFileWatcher.Name = "cxbFileWatcher";
            this.cxbFileWatcher.Size = new System.Drawing.Size(103, 17);
            this.cxbFileWatcher.TabIndex = 27;
            this.cxbFileWatcher.Text = "File Watcher Off";
            this.cxbFileWatcher.UseVisualStyleBackColor = true;
            this.cxbFileWatcher.CheckedChanged += new System.EventHandler(this.cxbFileWatcher_CheckedChanged);
            // 
            // txbFileWatcher
            // 
            this.txbFileWatcher.BackColor = System.Drawing.Color.Black;
            this.txbFileWatcher.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFileWatcher.ForeColor = System.Drawing.Color.Lime;
            this.txbFileWatcher.Location = new System.Drawing.Point(526, 180);
            this.txbFileWatcher.Multiline = true;
            this.txbFileWatcher.Name = "txbFileWatcher";
            this.txbFileWatcher.Size = new System.Drawing.Size(253, 133);
            this.txbFileWatcher.TabIndex = 28;
            this.txbFileWatcher.Visible = false;
            // 
            // btnCryptFile
            // 
            this.btnCryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderSize = 2;
            this.btnCryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptFile.Location = new System.Drawing.Point(526, 105);
            this.btnCryptFile.Name = "btnCryptFile";
            this.btnCryptFile.Size = new System.Drawing.Size(120, 23);
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
            this.btnDecryptFile.Location = new System.Drawing.Point(659, 105);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(120, 23);
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
            this.lblFileCryptedSaved.Location = new System.Drawing.Point(523, 133);
            this.lblFileCryptedSaved.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileCryptedSaved.Name = "lblFileCryptedSaved";
            this.lblFileCryptedSaved.Size = new System.Drawing.Size(103, 15);
            this.lblFileCryptedSaved.TabIndex = 31;
            this.lblFileCryptedSaved.Text = "fileCryptedSaved";
            this.lblFileCryptedSaved.Visible = false;
            // 
            // lblFileDecryptedSaved
            // 
            this.lblFileDecryptedSaved.AutoSize = true;
            this.lblFileDecryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDecryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileDecryptedSaved.Location = new System.Drawing.Point(656, 131);
            this.lblFileDecryptedSaved.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileDecryptedSaved.Name = "lblFileDecryptedSaved";
            this.lblFileDecryptedSaved.Size = new System.Drawing.Size(110, 15);
            this.lblFileDecryptedSaved.TabIndex = 32;
            this.lblFileDecryptedSaved.Text = "fileDecryptedSaved";
            this.lblFileDecryptedSaved.Visible = false;
            // 
            // SimpleSubstitutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 327);
            this.Controls.Add(this.lblFileDecryptedSaved);
            this.Controls.Add(this.lblFileCryptedSaved);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnCryptFile);
            this.Controls.Add(this.txbFileWatcher);
            this.Controls.Add(this.cxbFileWatcher);
            this.Controls.Add(this.lblGenerateFileKey);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnGetFileKey);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDecryptText);
            this.Controls.Add(this.btnCryptText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCryptedDecryptedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomKey);
            this.Controls.Add(this.txbEnteredText);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleSubstitutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleSubstitutionForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimpleSubstitutionForm_MouseDown);
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
        private System.Windows.Forms.CheckBox cxbFileWatcher;
        private System.Windows.Forms.TextBox txbFileWatcher;
        private System.Windows.Forms.Button btnCryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Label lblFileCryptedSaved;
        private System.Windows.Forms.Label lblFileDecryptedSaved;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
    }
}