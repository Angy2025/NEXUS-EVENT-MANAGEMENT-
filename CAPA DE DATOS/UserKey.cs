using CAPA_DE_ENTIDADES.CACHE; 
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    // UserKey hereda de ConnectionToSql, lo que le da acceso al método GetConnection() 
    public class UserKey : ConnectionToSql
    {

        #region Metodos publicos

        // Valida las credenciales de un usuario y, si son correctas, carga sus datos en la caché
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
                            // Llenamos la clase estática (caché) con los datos del usuario

                            NewLoginUser.IdUser = reader.GetInt32(0); 
                            NewLoginUser.Nombre = reader.GetString(1);
                            NewLoginUser.Apellido = reader.GetString(2);
                            NewLoginUser.Email = reader.GetString(3);
                            NewLoginUser.Posicion = reader.GetString(4);
                            NewLoginUser.Password = reader.GetString(5);
                            NewLoginUser.FotoPath = reader.GetValue(6).ToString();

                        }
                    return true; // Usuario encontrado y autenticado correctamente, con foto correspondiente
                    }
                    else
                    {
                        return false; // Usuario no encontrado
                    }
                }
            }
        }

        #endregion
    }
}


