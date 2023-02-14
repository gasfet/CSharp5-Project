using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace mook_DataSecret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TripleDESCryptoServiceProvider Tdes = new TripleDESCryptoServiceProvider();
        private byte[] enrgbiv = new byte[] {67, 12, 3, 41, 66, 78, 34, 123};
        private byte[] enrgbkey = new byte[] {98, 45, 125, 56, 1, 60, 11, 38, 
            123, 54, 234, 9, 76, 20, 44, 7, 12, 223, 219, 95, 48, 156, 32, 239};
        private byte[] dergbiv = new byte[] { 67, 12, 3, 41, 66, 78, 34, 123 };
        private byte[] dergbkey = new byte[] {98, 45, 125, 56, 1, 60, 11, 38, 
            123, 54, 234, 9, 76, 20, 44, 7, 12, 223, 219, 95, 48, 156, 32, 239};

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (this.txtOriginal.Text != "")
            {
                Encrypt(this.txtOriginal.Text);
                this.txtEncrypt.Text = Encrypt(this.txtOriginal.Text);
            }
        }
        private string Encrypt(string thisEncode)
        {
            string encrypted = null;
            byte[] Code = UTF8Encoding.UTF8.GetBytes(thisEncode);
            encrypted = Convert.ToBase64String(Tdes.CreateEncryptor(enrgbkey,
                enrgbiv).TransformFinalBlock(Code, 0, Code.Length));
            return encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (this.txtEncrypt.Text != "")
            {
                this.txtDecrypt.Text = Decrypt(this.txtEncrypt.Text);
            }
        }

        private string Decrypt(string thisDecode)
        {
            string decrypted = null;
            byte[] Code = Convert.FromBase64String(thisDecode);
            decrypted = UTF8Encoding.UTF8.GetString(Tdes.CreateDecryptor(dergbkey,
                dergbiv).TransformFinalBlock(Code, 0, Code.Length));
            return decrypted;
        }

        private void btnEnDe_Click(object sender, EventArgs e)
        {
            var fp = Convert.ToInt32(this.ofdFile.ShowDialog());
            if (fp==1)
            {
                try
                {
                    EnDeFile(this.ofdFile.FileName);
                    MessageBox.Show("완료되었습니다.", 
                        "알림", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("실패하였습니다.", 
                        "알림", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        
        private void EnDeFile(string strFile)
        {
            var FS = new FileStream(strFile, FileMode.Open);
            byte[] Buffer = new byte[FS.Length];
            FS.Read(Buffer, 0, (int)FS.Length);
            for (int i =0; i < FS.Length; i++)
            {
                Buffer[i] = Buffer[i] ^= 0x0c;
            }
            FS.Close();

            var FW = new FileStream(strFile,FileMode.Create);
            FW.Write(Buffer, 0, Information.UBound(Buffer) + 1);
            FW.Close();
        }
    }
}
