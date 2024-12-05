using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//librería exclusiva para conexión a SQLServer
using System.Data.SqlClient;

namespace DB
{
    public class ConnectionDB
    {
        public static string SQLServer()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //servidor
            builder.DataSource = "DESKTOP-K6HFMQS";

            //base de datos
            builder.InitialCatalog = "Biblioteca";

            //usuario
            builder.UserID = "sa";

            //contraseña
            builder.Password = "12345678";

            //login SQL Server Authentication
            builder.IntegratedSecurity = false;

            //login Windows Authentication
            //builder.IntegratedSecurity = true;

            return builder.ToString();
        }
    }
}
