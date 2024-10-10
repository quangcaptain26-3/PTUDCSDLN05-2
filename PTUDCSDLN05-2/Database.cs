using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUDCSDLN05_2
{
    internal class Database
    {
        private static string connectionString = 
            @"Data Source=PHAMMINHQUANG;Initial Catalog=ptudcsdln051;Integrated Security=True;TrustServerCertificate=True";

        private static SqlConnection connection;

        public static DataTable Query(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            connection = new SqlConnection (connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
