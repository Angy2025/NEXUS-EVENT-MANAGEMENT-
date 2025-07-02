using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class UserKey : ConnectionToSql
    {
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                { 
                    command.Connection  = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE UserName = @User AND Password = @Password";
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; // Usuario encontrado
                    }
                    else
                    {
                        return false; // Usuario no encontrado
                    }
                }
            }
        }
    }
}
