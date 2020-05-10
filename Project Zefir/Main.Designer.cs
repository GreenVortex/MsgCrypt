namespace Project_Zefir
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InputData = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.Terminator = new System.Windows.Forms.PictureBox();
            this.Download = new System.Windows.Forms.PictureBox();
            this.Decrypt = new System.Windows.Forms.PictureBox();
            this.Encrypt = new System.Windows.Forms.PictureBox();
            this.Informator = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terminator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informator)).BeginInit();
            this.SuspendLayout();
            // 
            // InputData
            // 
            this.InputData.BackColor = System.Drawing.Color.White;
            this.InputData.Location = new System.Drawing.Point(16, 100);
            this.InputData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(508, 176);
            this.InputData.TabIndex = 5;
            this.InputData.Text = "";
            // 
            // clear
            // 
            this.clear.BackgroundImage = global::Project_Zefir.Properties.Resources.clear;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.Location = new System.Drawing.Point(400, 284);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 74);
            this.clear.TabIndex = 11;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Terminator
            // 
            this.Terminator.BackgroundImage = global::Project_Zefir.Properties.Resources.close;
            this.Terminator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Terminator.Location = new System.Drawing.Point(493, 1);
            this.Terminator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Terminator.Name = "Terminator";
            this.Terminator.Size = new System.Drawing.Size(47, 43);
            this.Terminator.TabIndex = 10;
            this.Terminator.TabStop = false;
            this.Terminator.Click += new System.EventHandler(this.Terminator_Click);
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.BackgroundImage = global::Project_Zefir.Properties.Resources.file;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Download.Location = new System.Drawing.Point(283, 284);
            this.Download.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(80, 74);
            this.Download.TabIndex = 9;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt.BackgroundImage = global::Project_Zefir.Properties.Resources.Decrypt;
            this.Decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Decrypt.Location = new System.Drawing.Point(167, 284);
            this.Decrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(80, 74);
            this.Decrypt.TabIndex = 8;
            this.Decrypt.TabStop = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.Encrypt.BackgroundImage = global::Project_Zefir.Properties.Resources.encrypt;
            this.Encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Encrypt.Location = new System.Drawing.Point(51, 284);
            this.Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(80, 74);
            this.Encrypt.TabIndex = 7;
            this.Encrypt.TabStop = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Informator
            // 
            this.Informator.BackColor = System.Drawing.Color.Transparent;
            this.Informator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Informator.BackgroundImage")));
            this.Informator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Informator.Location = new System.Drawing.Point(1, 1);
            this.Informator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Informator.Name = "Informator";
            this.Informator.Size = new System.Drawing.Size(67, 62);
            this.Informator.TabIndex = 6;
            this.Informator.TabStop = false;
            this.Informator.Click += new System.EventHandler(this.Informator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Developed by Jan  Andersson";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Terminator);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Informator);
            this.Controls.Add(this.InputData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Encryptor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terminator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Informator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox InputData;
        private System.Windows.Forms.PictureBox Informator;
        private System.Windows.Forms.PictureBox Encrypt;
        private System.Windows.Forms.PictureBox Decrypt;
        private System.Windows.Forms.PictureBox Download;
        private System.Windows.Forms.PictureBox Terminator;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.Label label2;
    }
}

