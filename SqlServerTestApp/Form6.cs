using System;
using System.Windows.Forms;


namespace SqlServerTestApp
{
    public partial class Form6 : Form
    {
        public Form6()
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


            string query = $@"INSERT INTO [dbo].[Актёры]
           ([Фамилия],[Имя],[Отчество],[Звание],[Стаж])
            VALUES('{textBox3.Text}','{textBox1.Text}','{textBox2.Text}','{textBox4.Text},'{textBox5.Text}')";


            int? d = DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("добавлено" + d + "строк");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
      