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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form3 frm3 = new Form3();

                frm3.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [dbo].[Производители]
           ([Производитель],[Марка автомобиля])
     VALUES('{textBox1.Text}','{textBox3.Text}')";
            int? d = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено" + d + "строк");

        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
    }


