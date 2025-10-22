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

        float Potega(float a, float b) //musi miec rzeczywista podstawe i naturalny wykladnik, funkcja float bo zwraca taka wartosc
        {
            float w = 1; //ustalamy pierwsze mnozenie
            for(int i = 0; i<b; i++)  //ilosc mnozen znana przez wykladnik
            {
                w = w * a;  //mnozenie
            }
            return w;
        }

        float SumaCyfr(float a) 
        {
            float suma = 0;
            float m;
            while (a != 0) 
            {
                m = a % 10;
                suma = suma + m;
                a = (a - m) / 10;
            }
           

            return suma;
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
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;
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
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;
            float wynik = 0;
            wynik = a - b;
            textBox3.Text = wynik.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            a = float.Parse(textBox1.Text);
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;
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
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;
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

        private void button5_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            string c = "z tej liczby nie da sie obliczyc NWD";
            float wynik;
            float nwd;
            a = float.Parse(textBox1.Text);
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;
            if ((Math.Floor(a) == a) && (Math.Floor(b) == b) && (a > 0) && (b > 0)) 
            {
                while (a != b) 
                {
                    if (a > b) 
                    {
                        a = a - b;
                    }
                    else 
                    {
                        b = b - a;
                    }

                }
                textBox3.Text = a.ToString();
            }
            else
            {
                textBox3.Text = "złe liczby";
            }
            
                    
                    

        }

        private void button6_Click(object sender, EventArgs e)
        {
            float a;    
            float b;
            a = float.Parse((textBox1.Text));
            
            if (label3.Visible == false)
            {
                b = 0;

            }
            else
            {
                b = int.Parse(textBox2.Text);
            }
            label3.Visible = true;
            textBox2.Visible = true;


            if ((Math.Floor(b) == b && b > 0))
            {
                textBox3.Text = Potega(a, b).ToString();
            }
            else
            {
                textBox3.Text = "niepoprawna potega";
            }
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            float a;
            a = float.Parse((textBox1.Text));
            if ((Math.Floor(a) == a && a > 0)) 
            {
                textBox3.Text = SumaCyfr(a).ToString();
                label3.Visible = false;
                textBox2.Visible = false;
            }
            else
            {
                textBox3.Text = "niepoprawna liczba";
            }
               
        }
    }
}
