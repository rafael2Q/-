﻿    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerTestApp
{
    public partial class DBConnectionForm : Form
    {
        public DBConnectionForm()
        {
            InitializeComponent();

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string datasource = serverBox.Text;
            string database = dbNameBox.Text;
            string username = usernameBox.Text ?? "";
            string userpass = userpassBox.Text ?? "";

            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Connection error! Some required fields not filled.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBConnectionService.SetSqlConnection(GetDBConnectionString(datasource, database, username, userpass)))
            {
                MessageBox.Show("Passed!", "Connection passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public string GetDBConnectionString(string datasource, string database, string username, string password)
        {
            string dataSourceStirng = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;";
            if (!string.IsNullOrEmpty(username))
            {
                dataSourceStirng += "User ID=" + username + ";Password=" + password + ";";
            }
            else
            {
                dataSourceStirng += "Integrated Security=SSPI;";
            }   
            return dataSourceStirng;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            
            this.Hide();
        }

        private void dbNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBConnectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}

