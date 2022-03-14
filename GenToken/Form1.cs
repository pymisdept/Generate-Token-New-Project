using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
            string prj = tb_prjCode.Text;
            if (prj == string.Empty)
            {
                MessageBox.Show("Please input the project code");
            }
            else
            {
                string token = EncryptClass.Encrypt(prj);
                string URL = @"https://pyapi.pyengineering.com/HealthDeclare/Form_ch?site=";
                tb_token.Text = token;
                tb_URL.Text = URL + token;
            }
        }

        private void btn_CPToken_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_token.Text);
        }

        private void btn_CopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_URL.Text);
        }
    }
    public class EncryptClass
    {
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "PaulY@2020";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }


}
