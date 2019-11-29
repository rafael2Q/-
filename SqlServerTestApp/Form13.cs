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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID_Покупка],[ID_Покупка] from [клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(items: list);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
            private void Button1_Click(object sender, EventArgs e)
            {
                int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
                string query = "Delete from dbo.Клиенты where [ID_Покупка]=" + id;
                int? result = DBConnectionService.SendCommandToSqlServer(query);
                if (result != null && result > 0)
                {
                    MessageBox.Show("Удалено");
                    comboBox1.SelectedItem = null;
                }
            }
        

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ФИО клиента], [Серия паспорта], [Номер паспорта], [Домашний адресс], [Телефон], [ID_Клиент], [ID_Покупка]

FROM [dbo].[Клиенты]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ФИО клиента", "ФИО клиента");
            dataGridView1.Columns.Add("Серия паспорта", "Серия паспорта");
            dataGridView1.Columns.Add("Номер паспорта", "Номер паспорта");
            dataGridView1.Columns.Add("Домашний адресс", "Домашний адресс");
            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns.Add("ID_Клиент", "ID_Клиент");
            dataGridView1.Columns.Add("ID_Покупка", "ID_Покупка");
            
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
            dataGridView1.Refresh();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }
    }
    }

