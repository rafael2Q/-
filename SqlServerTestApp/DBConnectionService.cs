using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlServerTestApp
{
    public static class DBConnectionService
    {
        public static string ConnectionString { get; set; }

        public static SqlConnection GetSqlConnection(string connectionString)
        {
            ConnectionString = connectionString;
            return new SqlConnection(connectionString);
        }

        public static bool IsSqlConnectionWorks(SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                sqlConnection.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int SendCommandToSqlServer(string command, SqlConnection sqlConnection)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            int rowsCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowsCount;
        }

        public static void SendQueryToSqlServer(string command, SqlConnection sqlConnection)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //логика чтения данных
            reader.Close();
            sqlConnection.Close();
        }
    }
}
