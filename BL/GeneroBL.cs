using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BE;
using DB;

namespace BL
{
    public class GeneroBL
    {
        public GeneroBL() { }

        public void Insert(GeneroBE generoBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Generos values(@Descripcion)";

                sqlCommand.Parameters.AddWithValue("@Descripcion", generoBE.Descripcion);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public void Update(GeneroBE generoBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Generos set " +
                                         "Descripcion=@Descripcion " +
                                         "where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@Descripcion", generoBE.Descripcion);
                sqlCommand.Parameters.AddWithValue("@ID", generoBE.ID);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public void Delete(int generoID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Generos where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@ID", generoID);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public GeneroBE FindById(int generoID)
        {
            GeneroBE generoBE = null;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Generos where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@ID", generoID);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    generoBE = new GeneroBE();

                    generoBE.ID = sqlDataReader.GetInt32(0);
                    generoBE.Descripcion = sqlDataReader.GetString(1);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return generoBE;
        }

        public List<GeneroBE> FindAll()
        {
            List<GeneroBE> list = new List<GeneroBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Generos order by ID";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    GeneroBE generoBE = new GeneroBE();

                    generoBE.ID = sqlDataReader.GetInt32(0);
                    generoBE.Descripcion = sqlDataReader.GetString(1);

                    list.Add(generoBE);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }
        public bool isDelete(int generoID)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Libros WHERE IdGenero = @ID";
                sqlCommand.Parameters.AddWithValue("@ID", generoID);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    delete = false;
                }

                sqlDataReader.Close();
            }

            return delete;
        }

    }
}
