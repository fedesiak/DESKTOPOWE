using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void sortuj(int[] tab, int rozmiar)   //void bo nie musimy zwracac teraz wartosci, bubblesort
        {
            int temp;
            for (int i = 0; i < rozmiar - 1; i++)
            {
                for(int j = 0; j < rozmiar - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        private int wyszukaj(int[] tab, int szukana, int poczatek, int koniec) //szukamy liczby w tablicy
        {

            int srodek = (poczatek + koniec)/2;
            while (poczatek <= koniec)
            {
                if (tab[srodek] == szukana)
                {
                    return srodek;
                }
                else
                {
                    if (szukana < tab[srodek])
                    {
                        koniec = srodek - 1;
                    }
                    else
                    {
                        poczatek = srodek + 1;
                    }
                }
            }
            return -999;
            
        }


        int[] tab; //zmienna globalna

        private void button1_Click(object sender, EventArgs e) //losowanie liczb do tabeli
        {
            dataGridView2.Visible = false;
            textBox1.Visible = true;
            tab = new int[dataGridView1.Columns.Count];
            Random random = new Random();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(1, 101);
                    tab[j] = (int)dataGridView1.Rows[i].Cells[j].Value; //zrzutowane na int
                }

            }
        }

        private void button2_Click(object sender, EventArgs e) //minimum
        {
            //alokacja pamieci
            int min = tab[0];
            dataGridView2.Visible = false;
            textBox1.Visible = true;
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];

                }
            }
            textBox1.Text = min.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //maksimum
        {
            int max = tab[0];
            dataGridView2.Visible = false;
            textBox1.Visible = true;
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];

                }
            }
            textBox1.Text = max.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //wypisanie sort z funkcji
        {
            dataGridView2.Visible = true;
            textBox1.Visible = false;
            sortuj(tab, 6);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = tab[j].ToString();
                }
                }


            }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            textBox1.Visible = false;
            label1.Text = "Podaj element który chcesz wyszukac w tablicy";
           int z =  wyszukaj(tab, 5, tab.Length - 1, Convert.ToInt32(textBox1.Text));
            label2.Text = "liczba została znaleziona na pozycji: " + z.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
