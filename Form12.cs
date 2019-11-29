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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"SELECT [ID_клиента], [ID_Товар], [доставка], [вид оплаты], [ID_Покупки], [дата]

FROM [dbo].[Покупка]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID_клиента", "ID_клиента");
            dataGridView1.Columns.Add("ID_Товар", "ID_Товар");
            dataGridView1.Columns.Add("доставка", "доставка");
            dataGridView1.Columns.Add("вид оплаты", "вид оплаты");
            dataGridView1.Columns.Add("ID_Покупки", "ID_Покупки");
            dataGridView1.Columns.Add("дата", "дата");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            dataGridView1.Refresh();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.Покупка where [ID_Товар]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox1.SelectedItem = null;
            }
        }

        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            string query = "select [ID_Товар],[ID_Товар] from [dbo].[покупка]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void Товар_Click(object sender, EventArgs e)
        {

        }
    }
}
    

