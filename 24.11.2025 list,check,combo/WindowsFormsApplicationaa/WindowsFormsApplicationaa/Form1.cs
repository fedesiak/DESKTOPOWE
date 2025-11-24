using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            bool b = false; //domyslnie
            a = textBox1.Text;
            int jezyki = 0;

            if (checkBox1.Checked)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            if (b == true)
            {
                textBox2.Text = "Uczeń " + a;
            }
            else
            {
                textBox2.Text = "Nie uczeń " + a;
            }

            textBox2.Text += " Płeć: ";
            if (radioButton2.Checked) 
            {
                textBox2.Text += "mężczyzna ";
            }
            else if(radioButton1.Checked)
            {
                textBox2.Text += "kobieta ";
            }

                textBox2.Text += " jezyki: ";
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                foreach (object wybor in checkedListBox1.CheckedItems)
                {

                    textBox2.Text += wybor.ToString() + ", ";
                }
            }
            else if(checkedListBox1.CheckedItems.Count <= 1)
            {
                foreach (object wybor in checkedListBox1.CheckedItems)
                {

                    textBox2.Text += wybor.ToString();
                }
            }
            else
            {
                textBox2.Text += "zaden";
            }

            string wybWartosc = comboBox1.SelectedItem.ToString();
            string wybWartosc2 = listBox1.SelectedItem.ToString();


            
            textBox3.Text = wybWartosc + ", ";
            textBox3.Text += "wykształcenie: " + wybWartosc2 + " ";

            ////////////////////////////////////////////////////////
            ///

            string odp = "zainteresowania: ";

            foreach(var wybor in listBox2.SelectedItems) 
            {
                odp += wybor.ToString() + ", ";
            }

            textBox3.Text += odp;
            
            
            

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
