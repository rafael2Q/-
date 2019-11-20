using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static SqlServerTestApp.Form4;

namespace SqlServerTestApp
{
    public partial class Form5 : Form
    {
        public Form5()
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
            string query = $@"INSERT INTO [dbo].[Занятость актёров в спектакле]
           ([id спектакля],[id актёра],[Роль],[Стоимость годового контракта])
        VALUES
           ({((IdentityItem)comboBox1.SelectedItem)?.Id},{((IdentityItem)comboBox2.SelectedItem)?.Id},'{textBox3.Text}','{textBox4.Text}')";

            int? d = DBConnectionService.SendCommandToSqlServer(query);

            MessageBox.Show("добавлено" + d + "строк");
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id],[id] from [Актёры]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(items: list);

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [id спектакля],[id спектакля] from [Занятость актёров в спектакле]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(items: list);
        }


    }
}
