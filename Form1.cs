using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                Random r = new Random();

                char[] small1s = "qrtypsdfjklmnbvcxzghw".ToCharArray();
                string small1String = "";
                for (int i = 0; i < 1; i++)
                {
                    small1String += small1s[r.Next(0, 21)].ToString();
                }

                char[] small2s = "euioa".ToCharArray();
                string small2String = "";
                for (int i = 0; i < 1; i++)
                {
                    small2String += small2s[r.Next(0, 5)].ToString();
                }

                char[] small11s = "qrtypsdfjklmnbvcxzghw".ToCharArray();
                string small11String = "";
                for (int i = 0; i < 1; i++)
                {
                    small11String += small11s[r.Next(0, 21)].ToString();
                }

                char[] small22s = "euioa".ToCharArray();
                string small22String = "";
                for (int i = 0; i < 1; i++)
                {
                    small22String += small22s[r.Next(0, 5)].ToString();
                }

                char[] numbers = "1234567890".ToCharArray();
                string numberSS = "";
                for (int i = 0; i < 4; i++)
                {
                    numberSS += numbers[r.Next(0, 10)].ToString();
                }

                textBox1.Text = (small11String + small22String + small1String + small2String + numberSS);

            }
            else if (radioButton2.Checked == true)
            {

                char[] bigs = "QRTYPSDFJKLMNBVCXZGHW".ToCharArray();
                Random r = new Random();
                string bigString = "";
                for (int i = 0; i < 1; i++)
                {
                    bigString += bigs[r.Next(0, 21)].ToString();
                }

                char[] small1s = "qrtypsdfjklmnbvcxzghw".ToCharArray();
                string small1String = "";
                for (int i = 0; i < 1; i++)
                {
                    small1String += small1s[r.Next(0, 21)].ToString();
                }

                char[] small2s = "euioa".ToCharArray();
                string small2String = "";
                for (int i = 0; i < 1; i++)
                {
                    small2String += small2s[r.Next(0, 5)].ToString();
                }

                char[] small11s = "qrtypsdfjklmnbvcxzghw".ToCharArray();
                string small11String = "";
                for (int i = 0; i < 1; i++)
                {
                    small11String += small11s[r.Next(0, 21)].ToString();
                }

                char[] small22s = "euioa".ToCharArray();
                string small22String = "";
                for (int i = 0; i < 1; i++)
                {
                    small22String += small22s[r.Next(0, 5)].ToString();
                }

                char[] numbers = "1234567890".ToCharArray();
                string numberSS = "";
                for (int i = 0; i < 5; i++)
                {
                    numberSS += numbers[r.Next(0, 10)].ToString();
                }
                textBox1.Text = (bigString + small22String + small11String + small2String + small1String + numberSS);

            }
            else if (radioButton3.Checked == true)
            {
                char[] bigs = "QRTYPSDFJKLMNBVCXZGHWEUAIO".ToCharArray();
                Random r = new Random();
                string bigString = "";
                for (int i = 0; i < 2; i++)
                {
                    bigString += bigs[r.Next(0, 26)].ToString();
                }
                char[] small1s = "qrtypsdfjklmnbvcxzghweuioa".ToCharArray();
                string small1String = "";
                for (int i = 0; i < 3; i++)
                {
                    small1String += small1s[r.Next(0, 26)].ToString();
                }
                char[] numbers = "1234567890".ToCharArray();
                string numberSS = "";
                for (int i = 0; i < 3; i++)
                {
                    numberSS += numbers[r.Next(0, 10)].ToString();
                }
                char[] symbols = "()!?".ToCharArray();
                string symbolSS = "";
                for (int i = 0; i < 2; i++)
                {
                    symbolSS += symbols[r.Next(0, 4)].ToString();
                }

                textBox1.Text = (bigString + small1String + numberSS + symbolSS);

            }
            else if (radioButton4.Checked == true)
            {

                char[] landn1 = "1234567890qwertyuiopasdfjklmnbvcxzQAZXSWEDCVFRTBNYUJMKIOLP()!?()!?()!?".ToCharArray();
                Random r = new Random();
                string random1String = "";
                for (int i = 0; i <= 12; i++)
                {
                    random1String += landn1[r.Next(0, 70)].ToString();
                }
                textBox1.Text = (random1String);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
