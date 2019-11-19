using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static SqlServerTestApp.Form4;

namespace SqlServerTestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query= $@"INSERT INTO [dbo].[Театр]
           ([Название театра],[Город],[Репертуар],[Стоимость билетов],[Стоимость билетов на премьеры])VALUES({((IdentityItem)comboBox1.SelectedItem)?.Id},{((IdentityItem)comboBox2.SelectedItem)?.Id},{((IdentityItem)comboBox3.SelectedItem)?.Id},'{textBox4.Text}','{textBox5.Text}')";
            int? d = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено" + d + "строк");
        }
        //название теара
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //город
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //репертуар
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //стоимость билетов
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //стоимость билетов на премьеру
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //название спектакля
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [Название театра],[Название театра] from [Театр]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [Город],[Город] from [Театр]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            string query = "select [Репертуар],[Репертуар] from [Театр]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(list);
        }

        
    }
}

