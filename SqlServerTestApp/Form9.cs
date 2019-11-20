using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
   
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void ClearAndAddColumnsInDataGridView(DataGridView dataGridView1, string v)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [id театра],[Репертуар],[Название театра],[Город],[Стоимость билетов],[Стоимость билетов на премьеры]

           FROM [dbo].[Театр]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("id театра", "id театра");
                dataGridView1.Columns.Add("Репертуар", "Репертуар");
                dataGridView1.Columns.Add("Название театра", "Название театра");
                dataGridView1.Columns.Add("Город", "Город");
                dataGridView1.Columns.Add("Стоимость билетов", "Стоимость билетов");
                dataGridView1.Columns.Add("Стоимость билетов на премьеры", "Стоимость билетов на премьеры");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2],row[3], row[4], row[5]);
                }
                dataGridView1.Refresh();
            }

         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            frm1.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             




        }

       
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
     string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=LSTU_Schedule_autumn20172018;" +
    "Integrated Security=true;";
            

        }
    }
}
