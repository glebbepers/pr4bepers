using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4bepers
{
    public partial class Form1 : Form
    {
        double x, i, f, u;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = (float)Convert.ToDouble(textBox1.Text);
                i = (float)Convert.ToDouble(textBox2.Text);
                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                {
                    MessageBox.Show("Должна быть выбрана какая-либо функция", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        f = (float)Math.Abs(Math.Sin(x));
                    }
                    if (radioButton2.Checked == true)
                    {
                        f = (float)Math.Pow(x, 2);
                    }
                    if (radioButton3.Checked == true)
                    {
                        f = (float)Math.Exp(x);
                    }
                    if (i % 2 != 0 && x > 0)
                    {
                        u = i * Math.Sqrt(f);
                    }
                    if (i % 2 == 0 && x < 0)
                    {
                        u = i / 2 * Math.Sqrt(Math.Abs(f));
                    }
                    if (i % 2 != 0 && x < 0 || i % 2 == 0 && x > 0 || x == 0)
                    {
                        u = Math.Sqrt(Math.Abs(i * f));
                        textBox3.Text = "При Х = " + textBox1.Text + Environment.NewLine +
                        " I = " + textBox2.Text + Environment.NewLine;
                        textBox3.Text += "\n\n" + "Значение ф-ии Е = " + u.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            

        
