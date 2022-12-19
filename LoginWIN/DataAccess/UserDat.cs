using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
   public class UserDat:ConnectionSql
    {
        
        public bool Login(string user, string password, string Cargo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Login where LoginUser = @user and password= @pass and Posicion = @Cargo";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@Cargo", Cargo);
                    command.CommandType= CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            
        }

        public bool RegistE(int UserID, string LoginUser, string password, string nombres, string Apellidos, string Posicion, string Email, string Telefono)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into login values (@ID,@User, @pass,@name,@lname,@position,@Email,@phone)";
                    command.Parameters.AddWithValue("@ID", UserID);
                    command.Parameters.AddWithValue("@user", LoginUser);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", nombres);
                    command.Parameters.AddWithValue("@lname", Apellidos);
                    command.Parameters.AddWithValue("@position", Posicion);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@phone", Telefono);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private SqlDataReader reader;
      public DataTable ListPos()
        {
            var conex = GetConnection();
            var comando = new SqlCommand();
            
            var Tabla = new DataTable();
            conex.Open();
            
            comando.CommandText = "ListarPos";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            Tabla.Load(reader);
            reader.Close();

            return Tabla;

        }

       public void conexion()
        {
            var conex = GetConnection();
            conex.Open();
            
        }

        public void conexclose()
        {
            var conex = GetConnection();
            conex.Close();

        }

    }
}
