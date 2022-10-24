﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tienda.SQL
{
    class SQLCon
    {
        private static string connetionString = null;
        public SqlConnection cnn;
        public void SQL_Connect(string server, string serverName, string password, string db)
        {
            connetionString = "Data Source=" + server + ";Initial Catalog=" + db + ";User Id=" + serverName + ";Password=" + password + ";MultipleActiveResultSets=true";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                Console.WriteLine($"SQL CONNECTION STARTED IN: {db}.");
            }
            catch (Exception ex)
            {
            }
        }

        public void openDB()
        {
            if (cnn != null && cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void closeDB()
        {
            cnn.Close();
        }
        public static bool IsServerConnected()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
