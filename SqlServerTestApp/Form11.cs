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
                string query = @"SELECT [id театра],[Репертуар],[Название театра],[Город],[Стоимость билетов],[Стоимость билетов на премьеры]

           FROM [dbo].[Театр]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("id театра", "id театра");
                dataGridView1.Columns.Add("Репертуар", "Репертуар");
                dataGridView1.Columns.Add("Название театра", "Название театра");
                dataGridView1.Columns.Add("Город", "Город");
                dataGridView1.Columns.Add("Стоимость билетов", "Стоимость билетов");
                dataGridView1.Columns.Add("Стоимость билетов на премьеры", "Стоимость билетов на премьеры");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
                dataGridView1.Refresh();
            }


        }
        //стаж
        private void button7_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [Стаж],[Дополнительная плата за стаж],[id стажа]

           FROM [dbo].[Стаж]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Стаж", "Стаж");
                dataGridView1.Columns.Add("Дополнительная плата за стаж", "Дополнительная плата за стаж");
                dataGridView1.Columns.Add("id стажа", "id стажа");
                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2]);
                }
                dataGridView1.Refresh();
            }





        }
        // спектакли
        private void button3_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT [id спектакля],[Год постановки],[Бюджет],[Название спектакля]

           FROM [dbo].[Спектакли]";
                ;
                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("id спектакля", "id спектакля");
                dataGridView1.Columns.Add("Год постановки", "Год постановки");
                dataGridView1.Columns.Add("Бюджет", "Бюджет");
                dataGridView1.Columns.Add("Название спектакля", "Название спектакля");
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
            string query = @"SELECT [id расписания],[id театра],[Стоимость билета],[Стоимость билета на премьеру],[День недели],[Дата начала спектакля],[Дата окончания спектакля],[Название спектакля]

           FROM [dbo].[Расписание спектаклей]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[id расписания", "[id расписания");
            dataGridView1.Columns.Add("id театра", "id театра");
            dataGridView1.Columns.Add("Стоимость билета", "Стоимость билета");
            dataGridView1.Columns.Add("Стоимость билета на премьеру", "Стоимость билета на премьеру");
            dataGridView1.Columns.Add("День неделиа", "День недели");
            dataGridView1.Columns.Add("Дата начала спектакля", "Дата начала спектакля");
            dataGridView1.Columns.Add("Дата окончания спектакля", "Дата окончания спектакля");
            dataGridView1.Columns.Add("Название спектакля", "Название спектакля");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
            dataGridView1.Refresh();
        }
        // Занятость актёров в спектакле
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id спектакля],[id актёра],[Роль],[Стоимость годового контракта]

           FROM [dbo].[Занятость актёров в спектакле]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id спектакля", "id спектакля");
            dataGridView1.Columns.Add("id актёра", "id актёра");
            dataGridView1.Columns.Add("Роль", "Роль");
            dataGridView1.Columns.Add("Стоимость годового контракта", "Стоимость годового контракта");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [id актёра],[id стажа],[Фамилия],[Имя],[Отчество],[Звание],[Стаж]

           FROM [dbo].[Актёры]";
            ;
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id актёра", "id актёра");
            dataGridView1.Columns.Add("id стажа", "id стажа");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Звание", "Звание");
            dataGridView1.Columns.Add("Стаж", "Стаж");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
            dataGridView1.Refresh();
        }
    }
}