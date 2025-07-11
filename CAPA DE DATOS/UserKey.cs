using CAPA_DE_ENTIDADES.CACHE;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    // La clase UserKey hereda de ConnectionToSql, lo que le da acceso al método GetConnection()
    // para no tener que repetir la cadena de conexión
    public class UserKey : ConnectionToSql
    {
        #region Métodos Públicos

        // Valida las credenciales de un usuario contra la base de datos
        // Si son correctas, carga sus datos en la caché estática para que estén disponibles en toda la aplicación
        public bool Login(string user, string password)
        {
            // El bloque 'using' asegura que la conexión a la base de datos se cierre siempre,
            // incluso si ocurre un error, liberando recursos del sistema
            using (var connection = GetConnection())
            {
                // Abre la comunicación con la base de datos
                connection.Open();

                // El 'using' para el comando también asegura que se liberen sus recursos
                using (var command = new SqlCommand())
                {
                    // Asocia el comando con la conexión que acabamos de abrir
                    command.Connection = connection;
                    // Define la consulta SQL para buscar un usuario que coincida con el email y la contraseña proporcionados
                    // Se usan parámetros (@User, @Password)
                    command.CommandText = "SELECT * FROM Usuarios WHERE Email = @User AND Password = @Password";

                    // Asigna los valores recibidos a los parámetros de la consulta
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = CommandType.Text;

                    // Ejecuta la consulta y devuelve un SqlDataReader, que es un objeto para leer los resultados fila por fila
                    SqlDataReader reader = command.ExecuteReader();

                    // La propiedad HasRows nos dice de forma rápida si la consulta devolvió al menos una fila
                    if (reader.HasRows)
                    {
                        // El bucle while se ejecuta mientras haya filas por leer (en este caso, solo hay una)
                        while (reader.Read())
                        {
                            //Llenamos la clase estática (caché) con los datos del usuario
                            // Esto permite que cualquier parte de la aplicación pueda acceder a la información
                            // del usuario logueado sin tener que volver a consultar la base de datos
                            // Se accede a las columnas por su índice 

                            NewLoginUser.IdUser = reader.GetInt32(0);
                            NewLoginUser.Nombre = reader.GetString(1);
                            NewLoginUser.Apellido = reader.GetString(2);
                            NewLoginUser.Email = reader.GetString(3);
                            NewLoginUser.Posicion = reader.GetString(4);
                            NewLoginUser.Password = reader.GetString(5);
                            // Usamos GetValue y ToString() para manejar de forma segura un posible valor nulo en la foto
                            NewLoginUser.FotoPath = reader.GetValue(6).ToString();
                        }
                        // Si se encontraron filas y se cargó la caché, el login fue exitoso
                        return true;
                    }
                    else
                    {
                        // Si la consulta no devolvió filas, significa que el usuario o la contraseña son incorrectos
                        return false;
                    }
                }
            }
        }

        #endregion
    }
}

