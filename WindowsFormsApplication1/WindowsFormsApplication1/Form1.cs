using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<decimal> num;
        List<string> dig;
        private bool Flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int j = 0;
            decimal Res = 0;

            if (num.Count > 0)
            {
                Res = num[0];
                for (j = 0; j < dig.Count; j++)
                {
                    switch (dig[j])
                    {
                        case "+":
                            Res += num[j + 1];
                            break;
                        case "-":
                            Res -= num[j + 1];
                            break;
                        case "*":
                            Res *= num[j + 1];
                            break;
                        case "/":
                            Res /= num[j + 1];
                            break;
                    }
                }
                tbxResult.Text = Res.ToString();
                Flag = true;
            }
        }

        private void Fill(object sender, EventArgs e)
        {    
            string str = ((System.Windows.Forms.Button)sender).Text;
            decimal tmp=0;

            if (decimal.TryParse(str, out tmp)==true)
            {
                if (Flag)
                {
                    Flag = false;
                    tbxResult.Text = "";
                    lbResult.Text = "";

                    num = new List<decimal>();
                    dig = new List<string>();
                }

                if (num.Count == dig.Count)
                {
                    num.Add(tmp);
                }
                else
                {
                    num[num.Count - 1] = decimal.Parse(num[num.Count - 1].ToString() + str);
                }
                tbxResult.Text += str;
                lbResult.Text += str;
            }
            else
            {
                if (Flag)
                {
                    Flag = false;
                }

                if (num.Count!=0)
                {
                    if(num.Count>dig.Count)
                    {
                        dig.Add(str);
                        tbxResult.Text += str;
                        lbResult.Text += str;
                    }
                    else if (num.Count == dig.Count)
                    {
                        tbxResult.Text = tbxResult.Text.Substring(0, tbxResult.Text.Length - 1) + str;
                        lbResult.Text = lbResult.Text.Substring(0, lbResult.Text.Length - 1) + str;
                        dig[dig.Count - 1] = str;
                    }
                    else if (num.Count < dig.Count)
                    {
                        MessageBox.Show("Not processed");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num = new List<decimal>();
            dig= new List<string>();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "";
            lbResult.Text = "";
            num = new List<decimal>();
            dig = new List<string>();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal tmp = 0;
            if (Flag)
            {
                Flag = false;
                tbxResult.Text = "";
                lbResult.Text = "";

                num = new List<decimal>();
                dig = new List<string>();
            }

            if (lbResult.Text.Length > 0)
            {
                string str1 = lbResult.Text.Substring(0, lbResult.Text.Length - 1);
                string str2 = lbResult.Text.Substring(lbResult.Text.Length - 1);
                string tmpStr = "";

                if (decimal.TryParse(str2, out tmp) == true)
                {
                    tmpStr = num[num.Count - 1].ToString();

                    if (tmpStr.Length == 1)
                    {
                        num.RemoveAt(num.Count - 1);
                    }
                    else
                    {
                        tmpStr = tmpStr.Substring(0, tmpStr.Length - 1);
                        num[num.Count - 1] = decimal.Parse(tmpStr);
                    }
                }
                else
                {
                    dig.RemoveAt(dig.Count - 1);
                }

                lbResult.Text = str1;
                tbxResult.Text = str1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
