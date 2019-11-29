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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID_Производителя], [ID_Производителя] from [dbo].[товарр]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID_Производителя],[ID_Товар],[Марка], [Модель], [Цвет], [Наличие], [Дата привоза товара], [цена], [КПП],[ID_Салон],[ID_Технические данные]

FROM [dbo].[товарр]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID_Производителя", "ID_Производителя");
            dataGridView1.Columns.Add("ID_Товар", "ID_Товар");
            dataGridView1.Columns.Add("Марка", "Марка");
            dataGridView1.Columns.Add("Модель", "Модель");
            dataGridView1.Columns.Add("Цвет", "Цвет");
            dataGridView1.Columns.Add("Наличие", "Наличие");
            dataGridView1.Columns.Add("Дата привоза товара", "Дата привоза товара");
            dataGridView1.Columns.Add("цена", "цена");
            dataGridView1.Columns.Add("КПП", "КПП");
            dataGridView1.Columns.Add("ID_Салон", "ID_Салон");
            dataGridView1.Columns.Add("ID_Технические данные", "ID_Технические данные");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.товарр where [ID_Производителя]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox1.SelectedItem = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

