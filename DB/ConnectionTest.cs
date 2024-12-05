using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DB
{
    public class ConnectionTest
    {
        public static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();
                Console.WriteLine("¡Conexión OK!");
                sqlConnection.Close();
            }

            Console.ReadLine();
        }
    }
}
