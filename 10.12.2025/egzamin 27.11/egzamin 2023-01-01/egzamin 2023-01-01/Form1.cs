using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_2023_01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ileZnakow = int.Parse(textBox3.Text);

            char[] tabMale = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z' };
            char[] tabDuze = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] tabCyfry = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] tabZnakiSpecjalne = { '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '{', '|', '}', '~' };
            /*char[] tabMaleDuze = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] tab2MaleDuzeCyfry = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] tab2CyfryZnaki = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '{', '|', '}', '~' };
            char[] tab2MaleDuzeZnaki = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '{', '|', '}', '~' };
            char[] tab3MaleDuzeCyfryZnaki = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '{', '|', '}', '~' };
            */
            string haslo = "";
            Random rand = new Random();
            int m = 0,n,p,q;
      
               if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    m = rand.Next(0, tabDuze.Length);
                    haslo += tabDuze[m];
                    n = rand.Next(0, tabCyfry.Length);
                    haslo += tabCyfry[n];
                    p = rand.Next(0,tabZnakiSpecjalne.Length);
                    haslo += tabZnakiSpecjalne[p];
                    for(int j=0; j<ileZnakow-3; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];
                       
                    }

                }
                else if(checkBox1.Checked && checkBox2.Checked)
                {
                    m = rand.Next(0, tabDuze.Length);
                    haslo += tabDuze[m];
                    n = rand.Next(0, tabCyfry.Length);
                    haslo += tabCyfry[n];
                    for (int j = 0; j < ileZnakow - 2; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else if(checkBox1.Checked && checkBox3.Checked)
                {
                    m = rand.Next(0, tabDuze.Length);
                    haslo += tabDuze[m];
                    p = rand.Next(0, tabZnakiSpecjalne.Length);
                    haslo += tabZnakiSpecjalne[p];
                    for (int j = 0; j < ileZnakow - 2; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else if(checkBox2.Checked && checkBox3.Checked)
                {
                    n = rand.Next(0, tabCyfry.Length);
                    haslo += tabCyfry[n];
                    p = rand.Next(0, tabZnakiSpecjalne.Length);
                    haslo += tabZnakiSpecjalne[p];
                    for (int j = 0; j < ileZnakow - 2; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else if(checkBox1.Checked)
                {
                    m = rand.Next(0, tabDuze.Length);
                    haslo += tabDuze[m];
                    for (int j = 0; j < ileZnakow - 1; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else if (checkBox2.Checked)
                {
                    n = rand.Next(0, tabCyfry.Length);
                    haslo += tabCyfry[n];
                    for (int j = 0; j < ileZnakow - 1; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else if (checkBox3.Checked)
                {
                    m = rand.Next(0, tabZnakiSpecjalne.Length);
                    haslo += tabZnakiSpecjalne[m];
                    for (int j = 0; j < ileZnakow - 1; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }
                else 
                {
                    for (int j = 0; j < ileZnakow; j++)
                    {
                        q = rand.Next(0, tabMale.Length);
                        haslo += tabMale[q];

                    }
                }

               

               /*   if (checkBox1.Checked)
                  {
                      m = rand.Next(0, tabMaleDuze.Length);
                      haslo += tabMaleDuze[m];
                  }
                  if (checkBox2.Checked)
                  {
                      m = rand.Next(0, tabCyfry.Length);
                      haslo += tabCyfry[m];
                  }
                  if (checkBox3.Checked)
                  {
                      m = rand.Next(0, tabZnakiSpecjalne.Length);
                      haslo += tabZnakiSpecjalne[m];

                  
            }
                else
                {
                    m = rand.Next(0, tabZnakiSpecjalne.Length);
                    haslo += tabMale[m];
                }
                //   haslo += tabMale[i];
               */


            
            MessageBox.Show(haslo);

        }
    }
}
