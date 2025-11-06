using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
        }
        int[] tab; //deklaracja tablicy

        private void sortuj(int[] tab, int rozmiar)  //funkcja sortujaca bubble sort
        {
            int temp;
            for (int i = 0; i < rozmiar - 1; i++)
            {
                for (int j = 0; j < rozmiar - 1; j++)
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

        private int wyszukajElement(int[] tab, int poczatek, int koniec, int szukana)
        {
            int srodek;

            while (poczatek <= koniec)
            {
                srodek = (poczatek + koniec) / 2;
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
            return -1;

        }

        private int wyszukajElementRekurencyjnie(int[] tab, int poczatek, int koniec, int szukana)
        {
            int srodek;
            if (poczatek > koniec)
            {
                return -1;
            }
            else
            {
                srodek = (poczatek + koniec) / 2;
                if (tab[srodek] == szukana)
                {
                    return srodek;
                }
                if (tab[srodek] > szukana)
                {
                    return wyszukajElementRekurencyjnie(tab, poczatek, srodek - 1, szukana);
                }
                else
                {
                    return wyszukajElementRekurencyjnie(tab, poczatek + 1, koniec, szukana);
                }
            }
        }

        private void merge(int[] tab, int poczatek, int koniec)  //scalanie
        {
            int i1, i2, i;
            int srodek = (poczatek + koniec) / 2;
            i1 = poczatek;
            i2 = srodek + 1;
            i = poczatek;  //poczatek wyniku w sensie graficznym
            int[] temp = new int[tab.Length];
            for (int j = 0; j < tab.Length; j++)
            {
                temp[j] = tab[j];
            }

            while (i1 <= srodek && i2 <= koniec)
            {
                if (temp[i1] < temp[i2])
                {
                    tab[i] = temp[i1];
                    i1++;
                }
                else
                {
                    tab[i] = temp[i2];
                    i2++;
                }
                i++;
            }


            if (i1 > srodek)
            {
                while (i2 <= koniec)
                {
                    tab[i] = temp[i2];
                    i2++;
                    i++;
                }
            }


            if (i2 > koniec)
            {
                while (i1 <= srodek)
                {
                    tab[i] = temp[i1];
                    i1++;
                    i++;
                }
            }
        }
        
        private void quicksort(int[] tab, int lewy, int prawy)
        {
            int srodek = tab[(lewy + prawy) / 2];
            int i, j, temp;
            i = lewy;
            j = prawy;
            do
            {
                while (tab[i] < srodek) { i++; }
                while (tab[j] < srodek) { j--; }

                if (i <= j)
                {
                    temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > lewy) quicksort(tab, lewy, j);
            if (j < prawy) quicksort(tab, i, prawy);
        }

        private void mergeSort(int[] tab, int poczatek, int koniec) //sortowanie przez Scalanie
        {
            int srodek = (poczatek + koniec) / 2;
            if (poczatek < srodek)
            {
                mergeSort(tab, poczatek, srodek);
            }
            if (srodek + 1 < koniec)
            {
                mergeSort(tab, srodek + 1, koniec);
            }

            merge(tab, poczatek, koniec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab = new int[dataGridView1.Columns.Count];
            Random random = new Random();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(1, 11);
                    tab[j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            dataGridView2.Visible = false;
            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];

                }
            }
            textBox1.Text = min.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            dataGridView2.Visible = false;
            int max = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];

                }
            }
            textBox1.Text = max.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            //sortuj(tab, 6);
            mergeSort(tab, 0, 5);
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
            label1.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "0";
            label1.Text = "Podaj liczbê któr¹ chcesz wyszukaæ";
            if (textBox2.Text == "")
            {
                textBox2.Text = "2";
            }
            else
            {
                int szuk = Convert.ToInt32(textBox2.Text);
                //    int z = wyszukajElement(tab, 0, tab.Length - 1, szuk);
                int z = wyszukajElementRekurencyjnie(tab, 0, tab.Length - 1, szuk) /* + 1 */;
                label2.Text = "Liczba zostala znaleziona na pozycji: " + z.ToString();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            quicksort(tab, 0, 5);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = tab[j].ToString();

                }
            }
        }
    }
}
