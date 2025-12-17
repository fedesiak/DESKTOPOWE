using System;
using System.Collections.Generic;
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

        public class WynikQuizu
        {
            public string Nazwisko { get; set; }
            public int Punkty { get; set; }

            public WynikQuizu(string nazwisko, int punkty)
            {
                Nazwisko = nazwisko;
                Punkty = punkty;
            }
        }

        private List<WynikQuizu> wynikiQuizu = new List<WynikQuizu>();
        private int liczbaUzytkownikow = 0;

        private int indeksAktualnegoPytania = 0;
        private string[] pytania;
        private float[] odpowiedzi;
        private int punkty = 0;
        private string nazwisko;

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
                }
                else if (label3.Text == "Obwód Kwadratu")
                {
                    float a = float.Parse(textBox1.Text);
                    float w = 0;
                    w = a * 4;
                    textBox3.Text = w.ToString();
                }
                else if (label3.Text == "Obwód Koła")
                {
                    float a = float.Parse(textBox1.Text);
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
            button3.Visible = false;
            button2.Visible = false;
            textBox3.Visible = true;
            label4.Visible = false;
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
            textBox2.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = true;
            button2.Visible = false;
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
            button3.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
            button1.Visible = true;
            label3.Visible = true;
            label1.Text = "promień: ";
            label3.Text = "Obwód Koła";
        }

        private void walecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            label4.Visible = false;
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
            button2.Visible = false;
            button3.Visible = false;
            textBox3.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label1.Text = "promień: ";
            label2.Text = "wysokość: ";
            label3.Text = "Objętość Stożka";
        }

        private void kulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label1.Text = "promień: ";
            label3.Text = "Pole Powierzchni Kuli";
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sprawdźNazwiskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label3.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            button3.Visible = true;
            button2.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            label1.Text = "Podaj nazwisko: ";
            button1.Text = "Sprawdź";
            label3.Text = "Sprawdź nazwisko";
        }

        private void rozwiążQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            label2.Visible = true;
            button3.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label1.Text = "Podaj nazwisko: ";
            label2.Text = "Odpowiedź";
            button1.Text = "Sprawdź";
            label3.Text = "Quiz";
            label4.Visible = true;
            label4.Text = "Podaj pole kwadratu o boku 4";

            pytania = new string[]
            {
                "Podaj pole kwadratu o boku 4",
                "Podaj pole prostokątu o bokach 5 i 4",
                "Podaj obwód koła o promieniu 2 do dwóch miejsc po przecinku",
                "Oblicz objętość walca o promieniu 3 i wysokości 2 do dwóch miejsc po przecinku",
                "Oblicz pole powierzchni kuli o promieniu 3 do dwóch miejsc po przecinku"
            };
            odpowiedzi = new float[] { 16, 20, 12.56f, 56.52f, 113.04f };
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Visible && string.IsNullOrEmpty(nazwisko))
            {
                nazwisko = textBox1.Text;
                textBox1.Visible = false;
                label1.Text = "Odpowiedź";
                textBox2.Visible = true;  
                return;
            }


            if (textBox2.Text != "")
            {
                float odpowiedź;
                if (!float.TryParse(textBox2.Text, out odpowiedź))
                {
                    MessageBox.Show("Wprowadź poprawną liczbę.");
                    return;
                }

                if (Math.Abs(odpowiedź - odpowiedzi[indeksAktualnegoPytania]) < 0.01f)
                {
                    punkty++;
                }

                indeksAktualnegoPytania++;

                if (indeksAktualnegoPytania < pytania.Length)
                {
                    label4.Text = pytania[indeksAktualnegoPytania];
                    textBox2.Clear();
                }
                else
                {
                    var istniejącyWynik = wynikiQuizu.FirstOrDefault(w => w.Nazwisko == nazwisko);

                    if (istniejącyWynik != null)
                    {
                        istniejącyWynik.Punkty = punkty;
                    }
                    else
                    {
                        wynikiQuizu.Add(new WynikQuizu(nazwisko, punkty));
                    }

                    MessageBox.Show($"Twój wynik: {punkty} / {pytania.Length}");

                    indeksAktualnegoPytania = 0;
                    punkty = 0;
                    nazwisko = "";
                    label1.Visible = true;
                    textBox1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Wprowadź odpowiedź.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nazwiskoDoSzukania = textBox1.Text;

            if (string.IsNullOrEmpty(nazwiskoDoSzukania))
            {
                MessageBox.Show("Wpisz nazwisko, aby wyszukać wynik.");
                return;
            }

            var wynik = wynikiQuizu.FirstOrDefault(w => w.Nazwisko == nazwiskoDoSzukania);

            if (wynik != null)
            {
                MessageBox.Show($"Nazwisko: {wynik.Nazwisko}\nPunkty: {wynik.Punkty}");
            }
            else
            {
                MessageBox.Show($"Nie znaleziono wyniku dla nazwiska: {nazwiskoDoSzukania}");
            }
        }
    }
}
