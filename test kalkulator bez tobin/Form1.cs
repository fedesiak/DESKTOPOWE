using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float w = a + b;
                textBox3.Text = w.ToString();
            }
            else
            {
                textBox3.Text = "puste pole";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            
                if (b == 0)
                {
                    textBox3.Text = "nie wolno dzielic przez 0";
                }
                else
                {
                    float w = a / b;
                    textBox3.Text = w.ToString();
                }
            }
            else
            {
                textBox3.Text = "puste pole";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a, b;
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                string c = "nie ma nwd";
                if (Math.Floor(a) == a && Math.Floor(b) == b && a > 0 && b > 0)
                {

                    while (a != b)
                    {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else if (a < b)
                        {
                            b = b - a;
                        }
                    }
                    textBox3.Text = a.ToString();
                }
                else
                {
                    textBox3.Text = "nie ma nwd";
                }
            }
            else
            {
                textBox3.Text = "puste pole";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float x, y;

                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
                float w = x;
                if (y == 0)
                {
                    w = 1;
                }
                else if (y > 0)
                {
                    for (int i = 1; i < y; i++)
                    {
                        w = w * x;
                    }

                }
                else
                {
                    for (int i = -1; i > y; i--)
                    {
                        w = (1 / w) * (1 / x);
                    }
                }



                textBox3.Text = w.ToString();

            }
            else
            {
                textBox3.Text = "puste pole";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                
                float a = float.Parse(textBox1.Text);
                float r, s = 0;
                if (a >= 0)
                {
                    while (a != 0)
                    {
                        r = a % 10;
                        s = s + r;
                        a = (a - r) / 10;

                    }
                    textBox3.Text = s.ToString();
                }
                else if (a < 0)
                {
                    textBox3.Text = "liczba ujemna";
                }
            }
               

            else
            {
                textBox3.Text = "puste pole";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                float a = float.Parse(textBox1.Text);
                float s = 1, w = a;
                if (a > 0)
                {
                    for (int i = 1; i < a; i++)
                    {
                        s = s * w;
                        w--;
                    }
                    textBox3.Text = s.ToString();

                }
                else if (a == 0)
                {
                    textBox3.Text = "0";
                }
                else if (a < 0)
                {
                    textBox3.Text = "ujemna liczba";
                }


            }
            else
            {
                textBox3.Text = "puste pole";
            }
        }
        }
            
           
           
        }
    

