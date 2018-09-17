using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingXORWinForms
{
    public partial class FormXor : Form
    {
        public FormXor()
        {
            InitializeComponent();
            txbWay.ReadOnly = true;
            txbByte.Text = 4096.ToString();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f=new OpenFileDialog())
            {
                f.Filter = "txt files (*.txt)|*.txt";
                f.RestoreDirectory = true;

                if(f.ShowDialog()==DialogResult.OK)
                {
                    txbWay.Text = f.FileName;
                }

                ReadFile();
            }
        }

        private string ReadFile()
        {
            string line = "";

            using (StreamReader sr = new StreamReader(txbWay.Text, System.Text.Encoding.Default))
            {
                line = sr.ReadToEnd();       
            }

            return line;
        }

        private void WriteFile(byte[] res)
        {
            using (StreamWriter sw = new StreamWriter(txbWay.Text, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(Encoding.Default.GetString(res));
            }
        }

        private void CodeFile()
        {
            string myText = ReadFile();

            byte[] txt = Encoding.Default.GetBytes(myText);
            byte[] myKey = Encoding.Default.GetBytes(txbKey.Text);
            byte[] res = new byte[myText.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                res[i] = (byte)(txt[i] ^ myKey[i % myKey.Length]);
            }

            WriteFile(res);
        }

        private async void UnCode()
        {
            string line = ReadFile();

            byte[] res = new byte[line.Length];
            byte[] key = Encoding.Default.GetBytes(txbKey.Text);

            byte[] txt = Encoding.Default.GetBytes(line);

            for (int i = 0; i < line.Length-2; i++)
            {
                res[i] = (byte)(txt[i] ^ key[i % txbKey.Text.Length]);
            }

            WriteFile(res);
        }

        private void bthCode_Click(object sender, EventArgs e)
        {
            CodeFile();
        }

        private void btnUncode_Click(object sender, EventArgs e)
        {
            UnCode();
        }
    }
}
