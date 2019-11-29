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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [Название], [ID_Салон], [Кол-во машин], [Адрес]

FROM [dbo].[Салон]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("ID_Салон", "ID_Салон");
            dataGridView1.Columns.Add("Кол-во машин", "Кол-во машин");
            dataGridView1.Columns.Add("Адрес", "Адрес");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            dataGridView1.Refresh();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [Кол-во машин], [Кол-во машин] from [dbo].[Салон]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(((IdentityItem)comboBox1.SelectedItem)?.Id);
            string query = "Delete from dbo.Салон where [Кол-во машин]=" + id;
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Удалено");
                comboBox1.SelectedItem = null;
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


