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
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlgorithmName = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(447, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
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
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "File Watcher";
            // 
            // lblAlgorithmName
            // 
            this.lblAlgorithmName.AutoSize = true;
            this.lblAlgorithmName.Location = new System.Drawing.Point(10, 374);
            this.lblAlgorithmName.Name = "lblAlgorithmName";
            this.lblAlgorithmName.Size = new System.Drawing.Size(118, 17);
            this.lblAlgorithmName.TabIndex = 12;
            this.lblAlgorithmName.Text = "lblAlgorithmName";
            // 
            // lvFiles
            // 
            this.lvFiles.BackColor = System.Drawing.Color.Black;
            this.lvFiles.ForeColor = System.Drawing.Color.Lime;
            this.lvFiles.Location = new System.Drawing.Point(12, 55);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(466, 224);
            this.lvFiles.TabIndex = 13;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // WatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.lblAlgorithmName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WatcherForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WatcherForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlgorithmName;
        private System.Windows.Forms.ListView lvFiles;
    }
}