using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4
{
    public partial class FrmCrypro : Form
    {
        public FrmCrypro()
        {
            InitializeComponent();
        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            string originalText = tbOrigText.Text;
            string key = "Key"; 
            string encryptedText = VigenereCipherEncrypt(originalText, key);
            tbCryptedText.Text = encryptedText;
        }
        private string VigenereCipherEncrypt(string text, string key)
        {
            string result = "";
            int keyIndex = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char keyChar = key[keyIndex % key.Length];
                    int shift = char.IsUpper(keyChar) ? char.ToUpper(c) - 'A' : char.ToLower(c) - 'a';
                    char encryptedChar = (char)(shift + keyChar);
                    result += encryptedChar;
                    keyIndex++;
                }
                else                
                    result += c;                
            }
            return result;
        }
    }
}
