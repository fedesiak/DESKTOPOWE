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
            char[] tabDuze = { 'A', 'B', 'C', 'D', 'E', 'F', };
            string haslo = "";
            Random rand = new Random();
            for(int i = 0; i < ileZnakow; i++)
            {
               
                {
                    haslo += tabMale[i];
                }
            }
            MessageBox.Show(haslo);

        }
    }
}
