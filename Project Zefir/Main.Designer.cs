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
            this.Password = new System.Windows.Forms.RichTextBox();
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
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(12, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(382, 144);
            this.Password.TabIndex = 5;
            this.Password.Text = "";
            // 
            // clear
            // 
            this.clear.BackgroundImage = global::Project_Zefir.Properties.Resources.clear;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.Location = new System.Drawing.Point(300, 231);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 11;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Terminator
            // 
            this.Terminator.BackgroundImage = global::Project_Zefir.Properties.Resources.close;
            this.Terminator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Terminator.Location = new System.Drawing.Point(370, 1);
            this.Terminator.Name = "Terminator";
            this.Terminator.Size = new System.Drawing.Size(35, 35);
            this.Terminator.TabIndex = 10;
            this.Terminator.TabStop = false;
            this.Terminator.Click += new System.EventHandler(this.Terminator_Click);
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.BackgroundImage = global::Project_Zefir.Properties.Resources.file;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Download.Location = new System.Drawing.Point(212, 231);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(60, 60);
            this.Download.TabIndex = 9;
            this.Download.TabStop = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt.BackgroundImage = global::Project_Zefir.Properties.Resources.Decrypt;
            this.Decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Decrypt.Location = new System.Drawing.Point(125, 231);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(60, 60);
            this.Decrypt.TabIndex = 8;
            this.Decrypt.TabStop = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.Encrypt.BackgroundImage = global::Project_Zefir.Properties.Resources.encrypt;
            this.Encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Encrypt.Location = new System.Drawing.Point(38, 231);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(60, 60);
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
            this.Informator.Name = "Informator";
            this.Informator.Size = new System.Drawing.Size(50, 50);
            this.Informator.TabIndex = 6;
            this.Informator.TabStop = false;
            this.Informator.Click += new System.EventHandler(this.Informator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(9, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Developed by Jan  Andersson";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Terminator);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Informator);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.RichTextBox Password;
        private System.Windows.Forms.PictureBox Informator;
        private System.Windows.Forms.PictureBox Encrypt;
        private System.Windows.Forms.PictureBox Decrypt;
        private System.Windows.Forms.PictureBox Download;
        private System.Windows.Forms.PictureBox Terminator;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.Label label2;
    }
}

