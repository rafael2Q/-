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
            SqlConnection con = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = Васильчугов Практика; Persist Security Info=True; User ID = nekekos; Password = 123;");
            con.Open();
            SqlCommand com = new SqlCommand($@"INSERT INTO [dbo].[Театр]
           ([Название театра],[Город],[Репертуар],[Стоимость билетов],[Стоимость билетов на премьеры])VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')", con);
            int d = com.ExecuteNonQuery();
            con.Close();
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
    }
}

