namespace Crypto_Client.Algoritham_Forms
{
    partial class SHA2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SHA2Form));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCryptText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCryptedDecryptedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEnteredText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCloud = new System.Windows.Forms.Button();
            this.btnFileWatcher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cxbSaveToCloud = new System.Windows.Forms.CheckBox();
            this.lblFileCryptedSaved = new System.Windows.Forms.Label();
            this.btnCryptFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnBack.TabIndex = 15;
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
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(11, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SHA2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCryptText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbCryptedDecryptedText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbEnteredText);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(10, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(462, 317);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash Text";
            // 
            // btnCryptText
            // 
            this.btnCryptText.BackColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptText.FlatAppearance.BorderSize = 2;
            this.btnCryptText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptText.ForeColor = System.Drawing.Color.Black;
            this.btnCryptText.Location = new System.Drawing.Point(21, 279);
            this.btnCryptText.Name = "btnCryptText";
            this.btnCryptText.Size = new System.Drawing.Size(134, 23);
            this.btnCryptText.TabIndex = 18;
            this.btnCryptText.Text = "Hash Text";
            this.btnCryptText.UseVisualStyleBackColor = false;
            this.btnCryptText.Click += new System.EventHandler(this.btnCryptText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hashed text:";
            // 
            // txbCryptedDecryptedText
            // 
            this.txbCryptedDecryptedText.BackColor = System.Drawing.Color.Black;
            this.txbCryptedDecryptedText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCryptedDecryptedText.ForeColor = System.Drawing.Color.Lime;
            this.txbCryptedDecryptedText.Location = new System.Drawing.Point(21, 164);
            this.txbCryptedDecryptedText.Multiline = true;
            this.txbCryptedDecryptedText.Name = "txbCryptedDecryptedText";
            this.txbCryptedDecryptedText.ReadOnly = true;
            this.txbCryptedDecryptedText.Size = new System.Drawing.Size(430, 103);
            this.txbCryptedDecryptedText.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter text:";
            // 
            // txbEnteredText
            // 
            this.txbEnteredText.BackColor = System.Drawing.Color.Black;
            this.txbEnteredText.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnteredText.ForeColor = System.Drawing.Color.Lime;
            this.txbEnteredText.Location = new System.Drawing.Point(21, 41);
            this.txbEnteredText.Multiline = true;
            this.txbEnteredText.Name = "txbEnteredText";
            this.txbEnteredText.Size = new System.Drawing.Size(430, 97);
            this.txbEnteredText.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloud);
            this.groupBox3.Controls.Add(this.btnFileWatcher);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(485, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(300, 88);
            this.groupBox3.TabIndex = 42;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cxbSaveToCloud);
            this.groupBox1.Controls.Add(this.lblFileCryptedSaved);
            this.groupBox1.Controls.Add(this.btnCryptFile);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnUploadFile);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(486, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(299, 97);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash File";
            // 
            // cxbSaveToCloud
            // 
            this.cxbSaveToCloud.AutoSize = true;
            this.cxbSaveToCloud.Location = new System.Drawing.Point(158, 70);
            this.cxbSaveToCloud.Margin = new System.Windows.Forms.Padding(2);
            this.cxbSaveToCloud.Name = "cxbSaveToCloud";
            this.cxbSaveToCloud.Size = new System.Drawing.Size(92, 17);
            this.cxbSaveToCloud.TabIndex = 33;
            this.cxbSaveToCloud.Text = "Save to cloud";
            this.cxbSaveToCloud.UseVisualStyleBackColor = true;
            // 
            // lblFileCryptedSaved
            // 
            this.lblFileCryptedSaved.AutoSize = true;
            this.lblFileCryptedSaved.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCryptedSaved.ForeColor = System.Drawing.Color.Lime;
            this.lblFileCryptedSaved.Location = new System.Drawing.Point(155, 44);
            this.lblFileCryptedSaved.MaximumSize = new System.Drawing.Size(110, 15);
            this.lblFileCryptedSaved.Name = "lblFileCryptedSaved";
            this.lblFileCryptedSaved.Size = new System.Drawing.Size(103, 15);
            this.lblFileCryptedSaved.TabIndex = 31;
            this.lblFileCryptedSaved.Text = "fileCryptedSaved";
            this.lblFileCryptedSaved.Visible = false;
            // 
            // btnCryptFile
            // 
            this.btnCryptFile.BackColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCryptFile.FlatAppearance.BorderSize = 2;
            this.btnCryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCryptFile.ForeColor = System.Drawing.Color.Black;
            this.btnCryptFile.Location = new System.Drawing.Point(158, 18);
            this.btnCryptFile.Name = "btnCryptFile";
            this.btnCryptFile.Size = new System.Drawing.Size(120, 23);
            this.btnCryptFile.TabIndex = 29;
            this.btnCryptFile.Text = "Hash File";
            this.btnCryptFile.UseVisualStyleBackColor = false;
            this.btnCryptFile.Click += new System.EventHandler(this.btnCryptFile_Click);
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
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "openFileDialog1";
            // 
            // SHA2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 365);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SHA2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHA2Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SHA2Form_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCryptText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCryptedDecryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEnteredText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCloud;
        private System.Windows.Forms.Button btnFileWatcher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cxbSaveToCloud;
        private System.Windows.Forms.Label lblFileCryptedSaved;
        private System.Windows.Forms.Button btnCryptFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
    }
}