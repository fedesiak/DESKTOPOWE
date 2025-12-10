using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kołoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label3.Text = "Pole Koła";
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                if (label3.Text == "Pole Koła")
                {
                    float a = float.Parse(textBox1.Text);
                    // float b = float.Parse(textBox2.Text);
                    float w = 0;
                    float pi = 3.14f;
                    w = pi * (a * a);
                    textBox3.Text = w.ToString();
                }
                
                 else if (label3.Text == "Pole Prostokątu")
                    {
                        float a = float.Parse(textBox1.Text);
                    if (textBox2.Text != "")
                    {

                        float b = float.Parse(textBox2.Text);
                        float w = 0;
                        w = a * b;
                        textBox3.Text = w.ToString();

                    }
                    else 
                    {
                        textBox3.Text = "podaj wartosc 2";
                    }

                        // float b = float.Parse(textBox2.Text);
                        
                    }
                
               

                else if (label3.Text == "Obwód Kwadratu")
                {
                    float a = float.Parse(textBox1.Text);
                    // float b = float.Parse(textBox2.Text);
                    float w = 0;
                    w = a * 4;
                    textBox3.Text = w.ToString();
                }

                else if (label3.Text == "Obwód Koła")
                {
                    float a = float.Parse(textBox1.Text);
                    // float b = float.Parse(textBox2.Text);
                    float w = 0;
                    float pi = 3.14f;
                    w = 2 * pi * a;
                    textBox3.Text = w.ToString();
                }
               
                else if (label3.Text == "Objętość Walca")
                {
                    float pi = 3.14f, w = 0;
                    float r = float.Parse(textBox1.Text);
                    if (textBox2.Text != "")
                    {
                        float h = float.Parse(textBox2.Text);
                        w = pi * (r * r) * h;
                        textBox3.Text = w.ToString();
                    }
                    else
                    {
                        textBox3.Text = "podaj wartosc 2";
                    }

                    // float b = float.Parse(textBox2.Text);

                }
                
                
         
                else if (label3.Text == "Objętość Stożka")
                {
                    float pi = 3.14f, w = 0;

                    float r = float.Parse(textBox1.Text);
                    if (textBox2.Text != "")
                    {
                        float h = float.Parse(textBox2.Text);
                    w = (h / 3) * pi * (r * r);
                    textBox3.Text = w.ToString();
                    }
                    else
                    {
                        textBox3.Text = "podaj wartosc 2";
                    }
                }
                else if (label3.Text == "Pole Powierzchni Kuli")
                {
                    float pi = 3.14f, w = 0;
                    float r = float.Parse(textBox1.Text);
                    w = 4 * pi * (r * r);
                    textBox3.Text = w.ToString();
                }
            }
            else
            {
                textBox3.Text = "Podaj wartosc 1";
            }
           


        }

        private void ątToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "1 bok: ";
            label2.Text = "2 bok: ";
            label3.Text = "Pole Prostokątu";
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
 
            textBox1.Visible = true;
            textBox2.Visible=false;
            label2.Visible=false;

            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "bok: ";
            label3.Text = "Obwód Kwadratu";
        }

        private void kołoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
 
            textBox1.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label3.Text = "Obwód Koła";
        }

        private void walecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //π r² h
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label2.Text = "wysokość: ";
            label3.Text = "Objętość Walca";
        }

        private void stożekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label2.Text = "wysokość: ";
            label3.Text = "Objętość Stożka";
        }

        private void kulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;

            label1.Visible = true;

            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label3.Text = "Pole Powierzchni Kuli";
        }
    }
}
