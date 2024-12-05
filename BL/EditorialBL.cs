using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BE;
using DB;

namespace BL
{
    public class EditorialBL
    {
        public EditorialBL() { }

        public void Insert(EditorialBE editorialBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "insert into Editoriales values(@Descripcion)";

                sqlCommand.Parameters.AddWithValue("@Descripcion", editorialBE.Descripcion);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public void Update(EditorialBE editorialBE)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "update Editoriales set " +
                                         "Descripcion=@Descripcion " +
                                         "where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@Descripcion", editorialBE.Descripcion);
                sqlCommand.Parameters.AddWithValue("@ID", editorialBE.ID);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public void Delete(int editorialID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "delete from Editoriales where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@ID", editorialID);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public EditorialBE FindById(int editorialID)
        {
            EditorialBE editorialBE = null;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Editoriales where ID=@ID";

                sqlCommand.Parameters.AddWithValue("@ID", editorialID);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    editorialBE = new EditorialBE();

                    editorialBE.ID = sqlDataReader.GetInt32(0);
                    editorialBE.Descripcion = sqlDataReader.GetString(1);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return editorialBE;
        }

        public List<EditorialBE> FindAll()
        {
            List<EditorialBE> list = new List<EditorialBE>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from Editoriales order by ID";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    EditorialBE editorialBE = new EditorialBE();

                    editorialBE.ID = sqlDataReader.GetInt32(0);
                    editorialBE.Descripcion = sqlDataReader.GetString(1);

                    list.Add(editorialBE);
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }

            return list;
        }

        public bool isDelete(int editorialID)
        {
            bool delete = true;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Libros WHERE IdEditorial = @ID";
                sqlCommand.Parameters.AddWithValue("@ID", editorialID);

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
