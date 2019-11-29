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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID_Товара], [ID_Товара] from [dbo].[Технические данные]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID_Товара], [Тип кузова], [Количество дверей], [Количество мест], [тип двигателя], [расположение двигателя], [Рабочий обьем], [ID_Технические данные]

FROM [dbo].[технические данные]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID_Товара", "ID_Товара");
            dataGridView1.Columns.Add("Тип кузова", "Тип кузова");
            dataGridView1.Columns.Add("Количество дверей", "Количество дверей");
            dataGridView1.Columns.Add("Количество мест", "Количество мест");
            dataGridView1.Columns.Add("тип двигателя", "тип двигателя");
            dataGridView1.Columns.Add("расположение двигателя", "расположение двигателя");
            dataGridView1.Columns.Add("Рабочий обьем", "Рабочий обьем");
            dataGridView1.Columns.Add("ID_Технические данные", "ID_Технические данные");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
                string query = "Delete from dbo.[Технические данные] where [ID_Товара]=" + id;
                int? result = DBConnectionService.SendCommandToSqlServer(query);
                if (result != null && result > 0)
                {
                    MessageBox.Show("Удалено");
                    comboBox1.SelectedItem = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }
    }
}
    
