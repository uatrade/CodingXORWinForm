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
    //public delegate void ProgressBarsDel(int num);
    //public delegate bool ProcessEnd();
    public partial class FormXor : Form
    {
        public event Action<int> ProgresBarsChange;

        bool EndProcess;
        bool CancelProcess;

        public FormXor()
        {
            InitializeComponent();
            txbWay.ReadOnly = true;

            ProgresBarsChange += ProcessChanged;   //Обработка прогресс бара

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            bthCode.Enabled = false;
            btnUncode.Enabled = false;
        }

        private bool ProcessEnded()
        {
            return true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f=new OpenFileDialog())
            {
                f.Filter = "txt files (*.txt)|*.txt";
                f.RestoreDirectory = true;

                if(f.ShowDialog()==DialogResult.OK)
                {
                    if(f.FileName!="")
                    txbWay.Text = f.FileName;
                }

               // if(f.FileName!="")
               //// ReadFile();
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

            progrBar.Maximum = txt.Length-1;
            progrBar.Step = 1;


            for (int i = 0; i < txt.Length; i++)
            {
                if (CancelProcess != true)
                {
                    res[i] = (byte)(txt[i] ^ myKey[i % myKey.Length]);

                    Thread.Sleep(50);
                    ProgresBarsChange(i);
                }
                else
                    break;
            }

            EndProcess = true;
            ProgresBarsChange(0);

            if(!CancelProcess)
            WriteFile(res);
            CancelProcess = false;
        }

        private void UnCode()
        {
            string line = ReadFile();

            byte[] res = new byte[line.Length];
            byte[] key = Encoding.Default.GetBytes(txbKey.Text);
            byte[] txt = Encoding.Default.GetBytes(line);

            progrBar.Maximum = line.Length-3;
            progrBar.Step = 1;

            for (int i = 0; i < line.Length-2; i++)      // убираем символу конца строки -2
            {
                if (CancelProcess != true)
                {
                    res[i] = (byte)(txt[i] ^ key[i % txbKey.Text.Length]);

                    Thread.Sleep(50);
                    ProgresBarsChange(i);
                }
                else
                    break;
            }

                EndProcess = true;
                ProgresBarsChange(0);

            if(!CancelProcess)
            WriteFile(res);
            CancelProcess = false;
        }

        private void bthCode_Click(object sender, EventArgs e)
        {
            Thread threadProgres = new Thread(CodeFile);
            threadProgres.Start();
        }

        private void btnUncode_Click(object sender, EventArgs e)
        {
            Thread threadProgres = new Thread(UnCode);
            threadProgres.Start();
        }


        private void ProcessChanged(int num)
        {
            if (!EndProcess && CancelProcess != true)
            {
                Action action = () => {
                    progrBar.Value = (int)num;
                };

                Invoke(action);
            }
            else
            {
                if(CancelProcess != true)
                MessageBox.Show("Завершено");

                progrBar.Value = 0;
                EndProcess = false;
            }

        }

        private void progrBar_Click(object sender, EventArgs e)
        {

        }

        private void txbWay_TextChanged(object sender, EventArgs e)
        {
            if(txbWay.Text!=null&& txbKey.Text.Length >= 6)
            {
                bthCode.Enabled = true;
                btnUncode.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelProcess = true;
            MessageBox.Show("Задача отменена");
        }

        private void txbKey_TextChanged(object sender, EventArgs e)
        {
            if (txbWay.Text != null && txbKey.Text.Length >= 6)
            {
                bthCode.Enabled = true;
                btnUncode.Enabled = true;
            }
        }
    }
}
