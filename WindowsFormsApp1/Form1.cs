using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        private string _password = "Password2123";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.DefaultExt = ".txt";

            if(op.ShowDialog() == DialogResult.OK)
            {
                FileNameText.Text = op.FileName;
                var fileStream = op.OpenFile();
                using (StreamReader sr = new StreamReader(op.FileName))
                {
                    FileText.Text = sr.ReadToEnd();
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            byte[] salt = GenerateSalt();
            var localLink = FileNameText.Text.Split('.')[0] + ".aes";
            FileStream fs = new FileStream(localLink,FileMode.Create);
            byte[] passwordBytes = Encoding.Unicode.GetBytes(_password);

            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);                                   
            aes.Mode = CipherMode.CFB;
            fs.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(FileNameText.Text, FileMode.Open);

            byte[] buffer = new byte[108576];
            int read;
            try
            {
                while((read = fsIn.Read(buffer,0,buffer.Length))>0)
                {
                    fsIn.Write(buffer, 0, read);
                }
            }
            catch(CrytongraphicException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
                fsIn.Close();
                using (StreamReader sr = new StreamReader(localLink))
                {
                    EncryptedText.Text = sr.ReadToEnd();
                }
                if(File.Exists(FileNameText.Text))
                {
                    File.Delete(FileNameText.Text);
                    FileNameText.Text = String.Empty;
                }
            }
        }

        private byte[] GenerateSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i< 10; i++)
                    rng.GetBytes(data);
                return data;
            }
        }
    }
}

    [Serializable]
    internal class CrytongraphicException : Exception
    {
        public CrytongraphicException()
        {
        }

        public CrytongraphicException(string message) : base(message)
        {
        }

        public CrytongraphicException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CrytongraphicException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }    