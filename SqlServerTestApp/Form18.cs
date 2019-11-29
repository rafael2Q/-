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
    public partial class Form18 : Form
    {
        public object FormExtentions { get; private set; }

        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = $@"UPDATE [dbo].[Клиенты] SET [ФИО клиента]='{textBox1.Text}',[Серия паспорта]='{textBox2.Text}',[Номер паспорта]='{textBox3.Text}',[Домашний адресс]='{textBox4.Text}',[телефон]='{textBox5.Text}'
            WHERE [ID_Покупка] ={((IdentityItem)comboBox1.SelectedItem)?.Id}";
            DBConnectionService.SendCommandToSqlServer(query);
            MessageBox.Show("Строка была успешно обновлена");
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "select [ID_Покупка],[ID_Покупка] from [клиенты]";
            var list = DBConnectionService.SendQueryToSqlServer(query)?.Select(row => new IdentityItem(row[0], row[1])).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(items: list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

        
    


