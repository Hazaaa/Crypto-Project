namespace Crypto_Client.Other_Forms
{
    partial class WatcherForm
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
            System.Windows.Forms.Button btnCryptFiles;
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlgorithmName = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.btnDecryptFiles = new System.Windows.Forms.Button();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnRandomKey = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            btnCryptFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCryptFiles
            // 
            btnCryptFiles.BackColor = System.Drawing.Color.Lime;
            btnCryptFiles.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnCryptFiles.FlatAppearance.BorderSize = 2;
            btnCryptFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCryptFiles.ForeColor = System.Drawing.Color.Black;
            btnCryptFiles.Location = new System.Drawing.Point(9, 268);
            btnCryptFiles.Name = "btnCryptFiles";
            btnCryptFiles.Size = new System.Drawing.Size(120, 23);
            btnCryptFiles.TabIndex = 31;
            btnCryptFiles.Text = "Crypt All Files";
            btnCryptFiles.UseVisualStyleBackColor = false;
            btnCryptFiles.Click += new System.EventHandler(this.btnCryptFiles_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(335, 2);
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
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "File Watcher";
            // 
            // lblAlgorithmName
            // 
            this.lblAlgorithmName.AutoSize = true;
            this.lblAlgorithmName.Location = new System.Drawing.Point(8, 304);
            this.lblAlgorithmName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlgorithmName.Name = "lblAlgorithmName";
            this.lblAlgorithmName.Size = new System.Drawing.Size(88, 13);
            this.lblAlgorithmName.TabIndex = 12;
            this.lblAlgorithmName.Text = "lblAlgorithmName";
            // 
            // lvFiles
            // 
            this.lvFiles.BackColor = System.Drawing.Color.Black;
            this.lvFiles.ForeColor = System.Drawing.Color.Lime;
            this.lvFiles.Location = new System.Drawing.Point(9, 45);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(350, 183);
            this.lvFiles.TabIndex = 13;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.List;
            // 
            // btnDecryptFiles
            // 
            this.btnDecryptFiles.BackColor = System.Drawing.Color.Lime;
            this.btnDecryptFiles.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDecryptFiles.FlatAppearance.BorderSize = 2;
            this.btnDecryptFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptFiles.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptFiles.Location = new System.Drawing.Point(236, 268);
            this.btnDecryptFiles.Name = "btnDecryptFiles";
            this.btnDecryptFiles.Size = new System.Drawing.Size(120, 23);
            this.btnDecryptFiles.TabIndex = 32;
            this.btnDecryptFiles.Text = "Decrypt All Files";
            this.btnDecryptFiles.UseVisualStyleBackColor = false;
            this.btnDecryptFiles.Click += new System.EventHandler(this.btnDecryptFiles_Click);
            // 
            // txbKey
            // 
            this.txbKey.BackColor = System.Drawing.Color.Black;
            this.txbKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.ForeColor = System.Drawing.Color.Lime;
            this.txbKey.Location = new System.Drawing.Point(64, 240);
            this.txbKey.MaxLength = 999999999;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(166, 20);
            this.txbKey.TabIndex = 34;
            this.txbKey.Visible = false;
            // 
            // btnRandomKey
            // 
            this.btnRandomKey.BackColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRandomKey.FlatAppearance.BorderSize = 2;
            this.btnRandomKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomKey.ForeColor = System.Drawing.Color.Black;
            this.btnRandomKey.Location = new System.Drawing.Point(236, 239);
            this.btnRandomKey.Name = "btnRandomKey";
            this.btnRandomKey.Size = new System.Drawing.Size(123, 23);
            this.btnRandomKey.TabIndex = 33;
            this.btnRandomKey.Text = "Random key";
            this.btnRandomKey.UseVisualStyleBackColor = false;
            this.btnRandomKey.Visible = false;
            this.btnRandomKey.Click += new System.EventHandler(this.btnRandomKey_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Lime;
            this.lblKey.Location = new System.Drawing.Point(12, 239);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(46, 20);
            this.lblKey.TabIndex = 35;
            this.lblKey.Text = "Key: ";
            this.lblKey.Visible = false;
            // 
            // WatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 325);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.btnRandomKey);
            this.Controls.Add(this.btnDecryptFiles);
            this.Controls.Add(btnCryptFiles);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.lblAlgorithmName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WatcherForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WatcherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WatcherForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WatcherForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlgorithmName;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Button btnDecryptFiles;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnRandomKey;
        private System.Windows.Forms.Label lblKey;
    }
}