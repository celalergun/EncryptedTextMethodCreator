using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedTextMethodCreator
{
    public partial class MainForm : Form
    {
        private readonly string _alphabet = "";
        private readonly Random _random = new Random();
        public MainForm()
        {
            InitializeComponent();
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
            textKey.Text = tmp;
            CreateMethod();
        }

        private void CreateMethod()
        {
            string dateTimeStr = DateTime.Now.ToString("yyyyMMddHHmmss");
            string hexBytes = string.Empty;
            string hexKey = string.Empty;
            string text = textText.Text;
            string key = textKey.Text;
            char[] encodedData = text.ToCharArray();

            if (rbXOR.Checked)
                encodedData = EncodeXOR(text, key);
            else if (rbAES.Checked)
                encodedData = EncodeAES(text, key);
            else if (rbHede.Checked)
                throw new ApplicationException("Bu nedir yaww?");
            hexBytes = ConvertDataToHex(hexBytes, encodedData);
            hexKey = ConvertKeyToHex(hexKey, key);

            textMethod.Clear();
            textMethod.AppendText("// Key: " + "'" + key + "'" + "\r\n");
            textMethod.AppendText("// String: " + text + "\r\n");
            textMethod.AppendText("private string String" + dateTimeStr + "()" + "\r\n");

            if (rbXOR.Checked)
                CreateXORMethod(hexBytes, hexKey);
            else if (rbAES.Checked)
                CreateAESMethod(hexBytes, hexKey);


            textResult.Text = hexBytes;
        }

        private void CreateAESMethod(string hexBytes, string hexKey)
        {
            textMethod.AppendText("{" + "\r\n");
            textMethod.AppendText("    uint[] _data = {" + hexBytes + "};\r\n");
            textMethod.AppendText("    uint[] _key = {" + hexKey + "};\r\n");
            textMethod.AppendText("    string _result = string.Empty;" + "\r\n");
            textMethod.AppendText("    for (int i = 0; i < _data.Length; i++)" + "\r\n");
            textMethod.AppendText("        _result += (char)(_data[i] ^ ~_key[i % _key.Length]);" + "\r\n");
            textMethod.AppendText("    return _result;" + "\r\n");
            textMethod.AppendText("}" + "\r\n");
        }

        private void CreateXORMethod(string hexBytes, string hexKey)
        {
            textMethod.AppendText("{" + "\r\n");
            textMethod.AppendText("    uint[] _data = {" + hexBytes + "};\r\n");
            textMethod.AppendText("    uint[] _key = {" + hexKey + "};\r\n");
            textMethod.AppendText("    string _result = string.Empty;" + "\r\n");
            textMethod.AppendText("    for (int i = 0; i < _data.Length; i++)" + "\r\n");
            textMethod.AppendText("        _result += (char)(_data[i] ^ ~_key[i % _key.Length]);" + "\r\n");
            textMethod.AppendText("    return _result;" + "\r\n");
            textMethod.AppendText("}" + "\r\n");
        }

        private static string ConvertKeyToHex(string hexKey, string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                uint val = ~(uint)key[i];
                hexKey += $"0x{val:X}, ";
            }

            return hexKey;
        }

        private static string ConvertDataToHex(string hexBytes, char[] encodedData)
        {
            for (int i = 0; i < encodedData.Length; i++)
            {
                uint val = (uint)encodedData[i];
                hexBytes += $"0x{val:X}, ";
            }

            return hexBytes;
        }

        private char[] EncodeAES(string text, string key)
        {
            throw new NotImplementedException("Not yet...");
        }

        private char[] EncodeXOR(string text, string key)
        {
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] ^= key[i % key.Length];
            }
            return charArray;
        }

        private void textText_TextChanged(object sender, EventArgs e)
        {
            CreateMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRandom.PerformClick();
        }
    }
}
