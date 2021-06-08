using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Coordinates
{
    public static class DatabaseConnection
    {
        public static SqlConnection Connection()
        {
            //your connection string 
            string connString = @"Data Source=" + "SERVER_NAME" + ";Initial Catalog="
                        + "Coordinates" + ";Persist Security Info=True;User ID=" + "DB_USERID" + ";Password=" + "DB_PASSWORD";
            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);
            try
            {

                //open connection
                conn.Open();

                return conn;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }
    }
}
