using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            float wynik = 0;
            wynik = a + b;
            textBox3.Text = wynik.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            float wynik = 0;
            wynik = a - b;
            textBox3.Text = wynik.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            float wynik = 0;
            wynik = a * b;
            textBox3.Text = wynik.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            string c = "nie wolno dzielic przez 0";
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            float wynik = 0;
            if (a == 0 || b == 0)
            {
                textBox3.Text = c.ToString();
            }
            else {
                wynik = a / b;
                textBox3.Text = wynik.ToString();
            }
              
        }
    }
}
