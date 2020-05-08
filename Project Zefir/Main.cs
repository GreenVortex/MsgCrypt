using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project_Zefir
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Form UI
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //End Of UI

        //Encoder Function
        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        //Decoder Function
        static public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;

        }
        //On enter encrypt

        private void Download_Click(object sender, EventArgs e)
        {
            if (File.Exists("Encrypted Dump"))
            {
                File.Delete("Encrypted Dump");
            }

            using (FileStream fs = File.Create("Encrypted Dump"))
            {
                // Add some text to file    
                byte[] author = new UTF8Encoding(true).GetBytes(Password.Text);
                fs.Write(author, 0, author.Length);
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string myData = Password.Text;
            string myDataEncoded = EncodeTo64(myData);
            Password.Text = myDataEncoded;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string myDataEncoded = Password.Text;
                string myDataUnencoded = DecodeFrom64(myDataEncoded);
                Password.Text = myDataUnencoded;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You can not encrypt a string  that has not been encrypted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Terminator_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Password.Clear();
        }

        private void Informator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Below you will find tools in the following order; encrypt,decrypt,dump as file,clear","How to use",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
