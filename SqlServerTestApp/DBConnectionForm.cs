﻿using System;
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
            string username = usernameBox.Text;
            string userpass = userpassBox.Text ?? "";

            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Connection error! Some required fields not filled.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = GetDBConnection(datasource, database, username, userpass);
            
            if(DBConnectionService.IsSqlConnectionWorks(connection))
            {
                MessageBox.Show("Connection passed!", "Connection passed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ошибка!", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = DBConnectionService.GetSqlConnection(connString);
            return conn;
        }
    }
}
