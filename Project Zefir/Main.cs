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
        {if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

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
            //Check if file exists and if it does delete it
            if (File.Exists("Encrypted Dump"))
            {
                File.Delete("Encrypted Dump");
            }

            //Create file in IO stream for prcessing
            using (FileStream fs = File.Create("Encrypted Dump"))
            {
                // Add some text to file    
                byte[] author = new UTF8Encoding(true).GetBytes(InputData.Text);
                fs.Write(author, 0, author.Length);
            }
        }

        //Encryption button
        private void Encrypt_Click(object sender, EventArgs e)
        {
            string myData = InputData.Text;
            string myDataEncoded = EncodeTo64(myData);
            InputData.Text = myDataEncoded;
        }

        //Decryption method button
        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string myDataEncoded = InputData.Text;
                string myDataUnencoded = DecodeFrom64(myDataEncoded);
                InputData.Text = myDataUnencoded;
            }
            //Error handler for attempting to encrypt string that has not being encrypted
            catch (System.FormatException)
            {
                MessageBox.Show("You can not encrypt a string  that has not been encrypted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Application ecit button
        private void Terminator_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clear Data field button
        private void Clear_Click(object sender, EventArgs e)
        {
            InputData.Clear();
        }

        //Usage Information
        private void Informator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Below you will find tools in the following order; encrypt,decrypt,dump as file,clear","How to use",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
