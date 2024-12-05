using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BE;
using DB;

namespace BL
{
    public class LibroBL
    {
        public LibroBL() { }

        public void Insert(LibroBE libroBE)
        {
          
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "insert into Libros values(@ISBN, @Titulo, @Edicion, @IdGenero, @IdEditorial)";

                    sqlCommand.Parameters.AddWithValue("@ISBN", libroBE.ISBN);
                    sqlCommand.Parameters.AddWithValue("@Titulo", libroBE.Titulo);
                    sqlCommand.Parameters.AddWithValue("@Edicion", libroBE.Edicion);
                    sqlCommand.Parameters.AddWithValue("@IdGenero", libroBE.IdGenero);
                    sqlCommand.Parameters.AddWithValue("@IdEditorial", libroBE.IdEditorial);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            
          
        }

        public void Update(LibroBE libroBE)
        {
          
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "update Libros set " +
                                             "ISBN=@ISBN, Titulo=@Titulo, Edicion=@Edicion, IdGenero=@IdGenero, IdEditorial=@IdEditorial " +
                                             "where ISBN=@ISBN";

                    sqlCommand.Parameters.AddWithValue("@ISBN", libroBE.ISBN);
                    sqlCommand.Parameters.AddWithValue("@Titulo", libroBE.Titulo);
                    sqlCommand.Parameters.AddWithValue("@Edicion", libroBE.Edicion);
                    sqlCommand.Parameters.AddWithValue("@IdGenero", libroBE.IdGenero);
                    sqlCommand.Parameters.AddWithValue("@IdEditorial", libroBE.IdEditorial);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }
            
        

        public void Delete(string isbn)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Libros where ISBN=@ISBN";

                sqlCommand.Parameters.AddWithValue("@ISBN", isbn);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public LibroBE FindByISBN(string isbn)
        {
            LibroBE libroBE = null;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros where ISBN=@ISBN";

                sqlCommand.Parameters.AddWithValue("@ISBN", isbn);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    libroBE = new LibroBE();

                    libroBE.ISBN = sqlDataReader.GetString(0);
                    libroBE.Titulo = sqlDataReader.GetString(1);
                    libroBE.Edicion = sqlDataReader.GetInt32(2);
                    libroBE.IdGenero = sqlDataReader.GetInt32(3);
                    libroBE.IdEditorial = sqlDataReader.GetInt32(4);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return libroBE;
        }

        public List<LibroBE> FindAll()
        {
            List<LibroBE> list = new List<LibroBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Libros";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    LibroBE libroBE = new LibroBE();

                    libroBE.ISBN = sqlDataReader.GetString(0);
                    libroBE.Titulo = sqlDataReader.GetString(1);
                    libroBE.Edicion = sqlDataReader.GetInt32(2);
                    libroBE.IdGenero = sqlDataReader.GetInt32(3);
                    libroBE.IdEditorial = sqlDataReader.GetInt32(4);

                    list.Add(libroBE);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        
    }
}
