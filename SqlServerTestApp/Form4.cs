using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SqlServerTestApp
{
    public partial class Form4 : Form
    {
        public Form4()
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
           // SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = Васильчугов Практика; Persist Security Info=True; User ID = nekekos; Password = 123;");
           // con.Open();
           // SqlCommand com = new SqlCommand($@"INSERT INTO [dbo].[Расписание спектаклей]
           //([Стоимость билета],[Стоимость билета на премьеру],[День недели],[Дата начала спектакля],[Дата окончания спектакля])VALUES('{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{dateTimePicker1.Value}','{dateTimePicker2.Value}')", con);
           // int d = com.ExecuteNonQuery();
           // con.Close();
           if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("ошибка");
                return;
            }
            string query = $@"INSERT INTO [dbo].[Расписание спектаклей]
           ([id спектакля],[id театра],[Стоимость билета],[Стоимость билета на премьеру],[День недели],[Дата начала спектакля],[Дата окончания спектакля])VALUES({((IdentityItem)comboBox1.SelectedItem)?.Id},{((IdentityItem)comboBox2.SelectedItem)?.Id},'{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{dateTimePicker1.Value}','{dateTimePicker2.Value}')";
            int? d = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено" + d + "строк");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public class IdentityItem
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public IdentityItem(string id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [id спектакля],[id театра] from [Расписание спектаклей]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "select [id театра],[Название театра] from [Театр]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(list);


           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}