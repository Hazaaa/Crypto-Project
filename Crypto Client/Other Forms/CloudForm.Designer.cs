namespace Crypto_Client.Other_Forms
{
    partial class CloudForm
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
            this.lvFiles = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.sfdDownloadFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lvFiles
            // 
            this.lvFiles.BackColor = System.Drawing.Color.Black;
            this.lvFiles.ForeColor = System.Drawing.Color.Lime;
            this.lvFiles.Location = new System.Drawing.Point(9, 45);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(350, 183);
            this.lvFiles.TabIndex = 16;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.List;
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
            this.btnClose.TabIndex = 15;
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
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cloud";
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.BackColor = System.Drawing.Color.Lime;
            this.btnDownloadFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDownloadFile.FlatAppearance.BorderSize = 2;
            this.btnDownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownloadFile.ForeColor = System.Drawing.Color.Black;
            this.btnDownloadFile.Location = new System.Drawing.Point(9, 248);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(134, 23);
            this.btnDownloadFile.TabIndex = 17;
            this.btnDownloadFile.Text = "Download File";
            this.btnDownloadFile.UseVisualStyleBackColor = false;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDeleteFile.FlatAppearance.BorderSize = 2;
            this.btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFile.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFile.Location = new System.Drawing.Point(222, 248);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteFile.TabIndex = 18;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // CloudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 300);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnDownloadFile);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloudForm";
            this.ShowIcon = false;
            this.Text = "CloudForm";
            this.Load += new System.EventHandler(this.CloudForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloudForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.SaveFileDialog sfdDownloadFile;
    }
}