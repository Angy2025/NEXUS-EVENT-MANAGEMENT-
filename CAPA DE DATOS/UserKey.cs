using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using CAPA_DE_ENTIDADES.CACHE; 

namespace CapaDatos
{
    // UserKey hereda de ConnectionToSql, lo que le da acceso al método GetConnection() 
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
                    command.CommandText = "SELECT * FROM Usuarios WHERE Email = @User AND Password = @Password";
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = CommandType.Text;


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        { 
                            NewLoginUser.IdUser = reader.GetInt32(0); 
                            NewLoginUser.Nombre = reader.GetString(1);
                            NewLoginUser.Apellido = reader.GetString(2);
                            NewLoginUser.Email = reader.GetString(3);
                            NewLoginUser.Posicion = reader.GetString(4);
                            NewLoginUser.Password = reader.GetString(5);

                        }
                    return true; // Usuario encontrado y autenticado correctamente
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
