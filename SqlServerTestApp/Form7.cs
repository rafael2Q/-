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
            
            string query=$@"INSERT INTO [dbo].[Спектакли]
           ([Год постановки],[Бюджет],[Название спектакля])VALUES('{dateTimePicker1.Value}','{textBox2.Text}','{textBox1.Text}')";
            int? d = DBConnectionService.SendCommandToSqlServer(query);
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
       

        private void Form7_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
