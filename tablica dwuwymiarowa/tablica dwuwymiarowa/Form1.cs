using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tablica_dwuwymiarowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[][] tab;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Random random = new Random();
            dataGridView1.Rows.Add(7);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) 
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++) 
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(1, 10);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    suma = suma + (int)dataGridView1.Rows[i].Cells[j].Value;
                }
                textBox1.Text = suma.ToString();
             
                
            }
          
            
        }
    }
}
