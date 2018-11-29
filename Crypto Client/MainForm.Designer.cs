namespace Crypto_Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnXXTEA = new System.Windows.Forms.Button();
            this.btnKnapsack = new System.Windows.Forms.Button();
            this.btnSHA2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crypto Client";
            // 
            // btnSimple
            // 
            this.btnSimple.BackColor = System.Drawing.Color.Lime;
            this.btnSimple.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSimple.FlatAppearance.BorderSize = 2;
            this.btnSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimple.Location = new System.Drawing.Point(65, 166);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(107, 23);
            this.btnSimple.TabIndex = 3;
            this.btnSimple.Text = "Simple substitution";
            this.btnSimple.UseVisualStyleBackColor = false;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnXXTEA
            // 
            this.btnXXTEA.BackColor = System.Drawing.Color.Lime;
            this.btnXXTEA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXXTEA.Location = new System.Drawing.Point(65, 207);
            this.btnXXTEA.Name = "btnXXTEA";
            this.btnXXTEA.Size = new System.Drawing.Size(107, 23);
            this.btnXXTEA.TabIndex = 4;
            this.btnXXTEA.Text = "XXTEA";
            this.btnXXTEA.UseVisualStyleBackColor = false;
            // 
            // btnKnapsack
            // 
            this.btnKnapsack.BackColor = System.Drawing.Color.Lime;
            this.btnKnapsack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKnapsack.Location = new System.Drawing.Point(65, 248);
            this.btnKnapsack.Name = "btnKnapsack";
            this.btnKnapsack.Size = new System.Drawing.Size(107, 23);
            this.btnKnapsack.TabIndex = 5;
            this.btnKnapsack.Text = "Knapsack";
            this.btnKnapsack.UseVisualStyleBackColor = false;
            this.btnKnapsack.Click += new System.EventHandler(this.btnKnapsack_Click);
            // 
            // btnSHA2
            // 
            this.btnSHA2.BackColor = System.Drawing.Color.Lime;
            this.btnSHA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSHA2.Location = new System.Drawing.Point(65, 288);
            this.btnSHA2.Name = "btnSHA2";
            this.btnSHA2.Size = new System.Drawing.Size(107, 23);
            this.btnSHA2.TabIndex = 6;
            this.btnSHA2.Text = "SHA2";
            this.btnSHA2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(204, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(233, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSHA2);
            this.Controls.Add(this.btnKnapsack);
            this.Controls.Add(this.btnXXTEA);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Client";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnXXTEA;
        private System.Windows.Forms.Button btnKnapsack;
        private System.Windows.Forms.Button btnSHA2;
        private System.Windows.Forms.Button button1;
    }
}

