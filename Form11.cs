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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
        //театр

        private void button8_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [ID_Производителя],[ID_Товар],[Марка],[Модель],[Цвет],[Наличие],[Дата привоза товара],[цена],[КПП],[ID_Салон],[ID_Технические данные]

           FROM [dbo].[товарр]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("ID_Производителя", "ID_Производителя");
                dataGridView1.Columns.Add("ID_Товар", "ID_Товар");
                dataGridView1.Columns.Add("Марка", "Марка");
                dataGridView1.Columns.Add("Модель", "Модель");
                dataGridView1.Columns.Add("Цвет", "Цвет");
                dataGridView1.Columns.Add("Наличие", "Наличие");
                dataGridView1.Columns.Add("Дата привоза товара", "Дата привоза товара");
                dataGridView1.Columns.Add("КПП", "КПП");
                dataGridView1.Columns.Add("ID_Салон", "ID_Салон");
                dataGridView1.Columns.Add("ID_Технические данные", "ID_Технические данные");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[6], row[7], row[8], row[9], row[10]);
                }
                dataGridView1.Refresh();
            }


        }
        //стаж
        private void button7_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [Тип кузова],[Количество дверей],[Количество мест],[тип двигателя],[расположение двигателя],[Рабочий обьем],[ID_Технические данные],[ID_Товара]

           FROM [dbo].[технические данные]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Тип кузова", "Тип кузова");
                dataGridView1.Columns.Add("Количество дверей", "Количество дверей");
                dataGridView1.Columns.Add("тип двигателя", "тип двигателя");
                dataGridView1.Columns.Add("расположение двигателя", "расположение двигателя");
                dataGridView1.Columns.Add("Рабочий обьем", "Рабочий обьем");
                dataGridView1.Columns.Add("ID_Технические данные", "ID_Технические данные");
                dataGridView1.Columns.Add("ID_Товара", "ID_Товара");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                }
                dataGridView1.Refresh();
            }





        }
        // спектакли
        private void button3_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [Название],[ID_Салон],[Кол-во машин],[Адрес]

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
                dataGridView1.Columns.Add("ID_Салон", "Год постановки");
                dataGridView1.Columns.Add("Кол-во машин", "Кол-во машин");
                dataGridView1.Columns.Add("Адрес", "Адрес");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
                }
                dataGridView1.Refresh();
            }
        }
        // Расписание спектаклей
        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID_Производителя],[Производитель],[Марка автомобиля]

           FROM [dbo].[производители]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID_Производителя", "ID_Производителя");
            dataGridView1.Columns.Add("Производитель", "Производитель");
            dataGridView1.Columns.Add("Марка автомобиля", "Марка автомобиля");
       
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }
            dataGridView1.Refresh();
        }
        // Занятость актёров в спектакле
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ID_клиента],[дата],[доставка],[вид оплаты],[ID_Покупки],[ID_Товар]

           FROM [dbo].[покупка]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID_клиента", "ID_клиента");
            dataGridView1.Columns.Add("дата", "дата");
            dataGridView1.Columns.Add("доставка", "доставка");
            dataGridView1.Columns.Add("вид оплаты", "вид оплаты");
            dataGridView1.Columns.Add("ID_Покупки", "ID_Покупки");
            dataGridView1.Columns.Add("ID_Товар", "ID_Товар");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ФИО клиента],[Серия паспорта],[Номер паспорта],[Домашний адресс],[Телефон]

           FROM [dbo].[клиенты]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ФИО клиента", "ФИО клиента");
            dataGridView1.Columns.Add("Серия паспорта", "Серия паспорта");
            dataGridView1.Columns.Add("Номер паспорта", "Номер паспорта");
            dataGridView1.Columns.Add("Домашний адресс", "Домашний адресс");
            dataGridView1.Columns.Add("Телефон", "Телефон");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
            dataGridView1.Refresh();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}