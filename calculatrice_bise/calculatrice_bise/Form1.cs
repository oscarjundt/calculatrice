/*
###################################
calculatrice en C# en mode interface
fait par oscar jundt-schmitter
###################################
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice_bise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> nb = new List<string>();
        List<string> op = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            nb.Add("1");
            aff(textBox1, nb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nb.Add("2");
            aff(textBox1, nb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nb.Add("3");
            aff(textBox1, nb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nb.Add("4");
            aff(textBox1, nb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nb.Add("5");
            aff(textBox1, nb);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nb.Add("6");
            aff(textBox1, nb);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nb.Add("7");
            aff(textBox1, nb);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nb.Add("8");
            aff(textBox1, nb);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nb.Add("9");
            aff(textBox1, nb);
        }
        public static void aff(TextBox t,List<string> tt)
        {
            string a = "";
            for(int i = 0; i < tt.Count; i++)
            {
                a = a + tt[i];
            }
            t.Text = a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nb.Add("+");
            op.Add("+");
            aff(textBox1, nb);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a2 = "";
            string a3 = "";
            int nbb = nb.Count;
            string tr = "";
            for (int i5 = 0; i5 < op.Count; i5++)
            {
                for (int i2 = 0; i2 < nb.Count; i2++)
                {
                    if (i2 < nbb && nb[i2] != op[i5])
                    {
                        a2 = a2 + nb[i2];
                        Console.WriteLine(a2);
                    }
                    if (nb[i2] == op[i5])
                    {
                        tr = nb[i2];
                        nbb = i2;

                    }
                    if (i2 > nbb)
                    {
                        a3 = a3 + nb[i2];
                    }
                }
            }
            Console.WriteLine(a2+tr+a3);
            if (tr == "+")
            {
                double total = double.Parse(a2) + double.Parse(a3);
                textBox2.Text = total.ToString();
            }
            else if (tr == "*")
            {
                double total = double.Parse(a2) * double.Parse(a3);
                textBox2.Text = total.ToString();
            }
            else if (tr == "-")
            {
                double total = double.Parse(a2) - double.Parse(a3);
                textBox2.Text = total.ToString();
            }
            else if (tr == "/")
            {
                double total = double.Parse(a2) / double.Parse(a3);
                textBox2.Text = total.ToString();
            }
            //nb.Clear();
            //op.Clear();
            //textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nb.Add("*");
            op.Add("*");
            aff(textBox1, nb);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            nb.Clear();
            op.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        { 
            nb.Add("-");
            op.Add("-");
            aff(textBox1, nb);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nb.Add("/");
            op.Add("/");
            aff(textBox1, nb);

        }
    }
}
