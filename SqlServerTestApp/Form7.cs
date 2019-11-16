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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            SqlCommand com = new SqlCommand($@"INSERT INTO [dbo].[Спектакли]
           ([Год постановки],[Бюджет],[Название спектакля])VALUES('{dateTimePicker1.Value}','{textBox2.Text}','{textBox3.Text}')", con);
            int d = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("добавлено" + d + "строк");
            }
           
        //название театра
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
        //дата пикер
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
       // бюджет
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //название спектакля
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
