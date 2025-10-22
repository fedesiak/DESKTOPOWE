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

        /*
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
        */

        float Potega(float a, int b)
        {
            float w = 1;
            for (int i = 0; i < b; i++)
            {
                w = w * a;
            }
            return w;
        }

        float SumaCyfr(float a)
        {
            float s = 0;
            while (a != 0)
            {
                float r = a % 10;

                s = s + r;

                a = (a - r) / 10;
            }
            return s;
        }

        float silnia(int n)
        {
            float w = 0;
            if (n == 0)
            {
                w = 1;
            }
            else
            {
                return silnia(n - 1) * n;
            }
            return w;
        }
        /* bin to hex , hex to bin
        string ToBinary(int a)
        {
            int[] tab = new int[32];
            int i = 0;

            if (a == 0)
            {
                return "0";
            }

            while (a != 0)
            {
                tab[i] = a % 2;
                a = a / 2;
                i++;
            }

            string wynik = "";
            for (int j = i - 1; j >= 0; j--)
            {
                wynik += tab[j].ToString();
            }

            return wynik;
        }

        string ToHex(int a)
        {
            int[] tab = new int[32];
            int i = 0;

            if (a == 0)
            {
                return "0";
            }

            while (a != 0)
            {
                tab[i] = a % 16;
                a = a / 16;
                i++;
            }

            string wynik = "";
            for (int j = i - 1; j >= 0; j--)
            {
                switch (tab[j])
                {
                    case 10: wynik += "A"; break;
                    case 11: wynik += "B"; break;
                    case 12: wynik += "C"; break;
                    case 13: wynik += "D"; break;
                    case 14: wynik += "E"; break;
                    case 15: wynik += "F"; break;
                    default: wynik += tab[j].ToString(); break;
                }
            }

            return wynik;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                float a;
                float b;
                b = 0;
                a = float.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                float wynik = 0;
                wynik = a + b;
                textBox3.Text = wynik.ToString();


            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                float a;
                float b;
                b = 0;
                a = float.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                float wynik = 0;
                wynik = a - b;
                textBox3.Text = wynik.ToString();


            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            label3.Visible = true;
            textBox2.Visible = true;
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                float a;
                float b;
                b = 0;
                a = float.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                float wynik = 0;
                wynik = a * b;
                textBox3.Text = wynik.ToString();


            }
            else
            {
                textBox3.Text = "";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            textBox2.Visible = true;
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                float a;
                float b;
                string c = "nie dzielimy przez 0";
                b = 0;
                a = float.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                float wynik = 0;
                if (b == 0)
                {
                    textBox3.Text = c;
                }
                else
                {
                    wynik = a / b;
                    textBox3.Text = wynik.ToString();
                }
                textBox3.Text = wynik.ToString();


            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            textBox2.Visible = true;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a;
                float b;
                string c = "z tej liczby nie da sie obliczyc NWD";
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
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
                    textBox3.Text = c;

                }
            }
            else
            {
                textBox3.Text = "";
            }





        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                float a;
                float b;
                a = float.Parse((textBox1.Text));
                b = float.Parse(textBox2.Text);

                if ((Math.Floor(b) == b))
                {
                    if (b >= 0)
                    {
                        int c = int.Parse(textBox2.Text);
                        textBox3.Text = Potega(a, c).ToString();
                    }

                }
                else
                {
                    textBox3.Text = "niepoprawna potega";
                }

            }
            else
            {
                textBox3.Text = "";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            if (textBox1.Text != "")
            {
                float a;
                a = float.Parse((textBox1.Text));
                if ((Math.Floor(a) == a && a > 0))
                {

                    textBox3.Text = SumaCyfr(a).ToString();

                }
                else
                {
                    textBox3.Text = "niepoprawna liczba";
                }
            }
            else
            {
                textBox3.Text = "";
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            if (textBox1.Text != "")
            {

                float a = float.Parse(textBox1.Text);

                if (Math.Floor(a) != a)
                {
                    textBox3.Text = "Liczba musi być całkowita";
                }
                else if (a >= 0)
                {
                    int c = int.Parse(textBox1.Text);
                    float wynik = silnia(c);
                    textBox3.Text = wynik.ToString();
                }
                else
                {
                    textBox3.Text = "Liczba nie może być ujemna";
                }
            }
            else
            {
                textBox3.Text = "";
            }

        }
        /*

            private void button9_Click(object sender, EventArgs e)
            {
                label3.Visible = false;
                textBox2.Visible = false;
                if (textBox1.Text != "")
                {
                    int a = int.Parse(textBox1.Text);
                    string wynik = ToBinary(a);
                    textBox3.Text = wynik;
                }
                else
                {
                    textBox3.Text = "";
                }
            }

            private void button10_Click(object sender, EventArgs e)
            {
                label3.Visible = false;
                textBox2.Visible = false;
                if (textBox1.Text != "")
                {
                    int a = int.Parse(textBox1.Text);
                    string wynik = ToHex(a);
                    textBox3.Text = wynik;
                }
                else
                {
                    textBox3.Text = "";
                }
            }
      
        */
    }
}
