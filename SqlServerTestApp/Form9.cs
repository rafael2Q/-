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

    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void ClearAndAddColumnsInDataGridView(DataGridView dataGridView1, string v)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT[наличие],[марка],[модель] FROM[dbo].[товарр]";


                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("[наличие]", "наличие ");
                dataGridView1.Columns.Add("[марка]", "марка");
                dataGridView1.Columns.Add("[модель]", "модель");

                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2]);
                }
                dataGridView1.Refresh();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            frm1.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string query = @"SELECT[ID_Товара],[Тип кузова],[Количество дверей],[Количество мест],[тип двигателя],[расположение двигателя],[Рабочий обьем] FROM[dbo].[Технические данные] WHERE[ID_Товара] = '2'";


                var list = DBConnectionService.SendQueryToSqlServer(query);
                if (list == null || !list.Any())
                {
                    return;
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("[ID_Товара]", "ID_Товара ");
                dataGridView1.Columns.Add("[Тип кузова]", "Тип кузова");
                dataGridView1.Columns.Add("[Количество дверей]", "Количество дверей");
                dataGridView1.Columns.Add("[Количество мест]", "Количество мест ");
                dataGridView1.Columns.Add("[тип двигателя]", "тип двигателя ");
                dataGridView1.Columns.Add("[расположение двигателя]", "расположение двигателя ");
                dataGridView1.Columns.Add("[Рабочий обьем]", "Рабочий обьем ");
                


                foreach (var row in list)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                }
                dataGridView1.Refresh();
            }





        }


        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {// select distinct(Товарр.[ID_Товар]),[Марка],[Модель],[Цвет],[КПП],[Производитель] from[dbo].[производители],[dbo].[товарр]
        //WHERE Производители.Производитель='Германия' and Модель = 'C'


            {
                {
                    string query = @"select distinct [ID_Товар],[Марка],[Модель],[Цвет],[КПП],[Производитель] 
                        from dbo.[производители],[dbo].[товарр]
                        WHERE[Производитель] = 'Германия' and Модель = 'C'";


                    var list = DBConnectionService.SendQueryToSqlServer(query);
                    if (list == null || !list.Any())
                    {
                        return;
                    }
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("[ID_Товар]", "ID_Товар");
                    dataGridView1.Columns.Add("[Марка]", "Марка");
                    dataGridView1.Columns.Add("[Модель]", "Модель");
                    dataGridView1.Columns.Add("[Цвет]", "Цвет");
                    dataGridView1.Columns.Add("[КПП]", "КПП");
                    dataGridView1.Columns.Add("[Производитель]", "Производитель");


                    foreach (var row in list)
                    {
                        dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                    }
                    dataGridView1.Refresh();
                }



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = @"SELECT[ФИО клиента],[Серия паспорта],[Номер паспорта],[Домашний адресс],[Телефон] FROM[dbo].[Клиенты]";


            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[ФИО клиента]", "ФИО клиента ");
            dataGridView1.Columns.Add("[Серия паспорта]", "Серия паспорта");
            dataGridView1.Columns.Add("[Номер паспорта]", "Номер паспорта");
            dataGridView1.Columns.Add("[Домашний адресс]", "Домашний адресс");
            dataGridView1.Columns.Add("[Телефон]", "Телефон");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [ФИО клиента], [Марка] + ' '+ [Модель] as [Автомобиль], [вид оплаты] 
                            FROM[dbo].[клиенты] 
                            left join[покупка]
                            on[покупка].[ID_клиента] = [Клиенты].[ID_Клиент]
                              left join[товарр]
                            on[покупка].[ID_Товар] = [товарр].[ID_Товар]";

            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[ФИО клиента]", "ФИО клиента");
            dataGridView1.Columns.Add("[Автомобиль ]", "Автомобиль");
            dataGridView1.Columns.Add("[вид оплаты]", "вид оплаты");
            


            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2]);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"SELECT [Марка],[Модель],[Цвет],[Наличие],[Дата привоза товара],[цена],[КПП] FROM[dbo].[товарр] WHERE[Марка] = 'BMW' and [Наличие] = 'проданно'";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[Марка]", "Марка");
            dataGridView1.Columns.Add("[Модель]", "Модель");
            dataGridView1.Columns.Add("[Цвет]", "Цвет");
            dataGridView1.Columns.Add("[Наличие]", "Наличие");
            dataGridView1.Columns.Add("[Дата привоза товара]", "Дата привоза товара");
            dataGridView1.Columns.Add("[цена]", "цена");
            dataGridView1.Columns.Add("[КПП]", "КПП");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = @"SELECT[Марка],[Модель],[Цвет],[Наличие],[Дата привоза товара],[цена],[КПП] FROM[dbo].[товарр] WHERE[марка] = 'BMW' and  [Наличие] = 'проданно'";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[Марка]", "Марка");
            dataGridView1.Columns.Add("[Модель]", "Модель");
            dataGridView1.Columns.Add("[Цвет]", "Цвет");
            dataGridView1.Columns.Add("[Наличие]", "Наличие");
            dataGridView1.Columns.Add("[Дата привоза товара]", "Дата привоза товара");
            dataGridView1.Columns.Add("[цена]", "цена");
            dataGridView1.Columns.Add("[КПП]", "КПП");

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
            dataGridView1.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string query = @"SELECT[марка],[Модель],[Цвет],[Наличие] FROM[dbo].[товарр] WHERE[Цвет] = 'черный' and  [Наличие] = 'проданно'";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            if (list == null || !list.Any())
            {
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("[Марка]", "Марка");
            dataGridView1.Columns.Add("[Модель]", "Модель");
            dataGridView1.Columns.Add("[Цвет]", "Цвет");
            dataGridView1.Columns.Add("[Наличие]", "Наличие");
           

            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            dataGridView1.Refresh();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
