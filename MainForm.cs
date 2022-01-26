using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace EncryptedTextMethodCreator
{
    public partial class MainForm : Form
    {
        private readonly string _alphabet;
        private readonly Random _random = new();
        public MainForm()
        {
            InitializeComponent();
            Utility.TestEncodeDecodeXor();
            Utility.TestEncodeDecodeAes();
            _alphabet = CreateAlphabet();
        }

        private string CreateAlphabet()
        {
            string tmp = "";
            for (char c = ' '; c <= '~'; c++)
            {
                tmp += c;
            }
            return tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = "";
            for (int i = 0; i < 16; i++)
            {
                int indeks = _random.Next(0, _alphabet.Length);
                tmp += _alphabet[indeks];
            }
            tbKey.Text = tmp;
            CreateMethod();
        }

        private void textText_TextChanged(object sender, EventArgs e)
        {
            CreateMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRandom.PerformClick();
        }

        private void CreateMethod()
        {
            Utility.EncryptionType type;
            if (rbAES.Checked) type = Utility.EncryptionType.Aes;
            else if (rbXtea.Checked) type = Utility.EncryptionType.Xtea;
            else type = Utility.EncryptionType.Xor;

            var (hexBytes, hexKey) = Utility.EncodeData(type, tbClearText.Text, tbKey.Text);
            tbResult.Text = hexBytes.Replace("0x", "").Replace(",", "");
            tbMethod.Text = Utility.CreateMethod(type, tbClearText.Text, tbKey.Text, hexBytes, hexKey);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            CreateMethod();
        }
    }
}
