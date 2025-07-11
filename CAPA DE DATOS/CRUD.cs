using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace CapaDatos
{
    // La clase CRUD hereda de ConnectionToSql, lo que le da acceso directo
    // al método GetConnection() para obtener una conexión a la base de datos
    public class CRUD : ConnectionToSql
    {
        #region CREATE (Agregar)

        // Este método se encarga de insertar un nuevo registro de evento en la base de datos
        public bool Agregar(string nombre, string lugar, DateTime fechahora, string tipo, int capacidad, string estatus)
        {
            // El bloque 'using' asegura que la conexión a la base de datos se cierre automáticamente
            // al finalizar, incluso si ocurre un error
            using (var conn = GetConnection())
            {
                try
                {
                    // Abre la comunicación con la base de datos
                    conn.Open();
                    // Define la consulta SQL para la inserción.
                    // para prevenir inyección SQL, una práctica de seguridad fundamental
                    var query = "INSERT INTO Evento (Nombre, Lugar, FechaHora, Categoria, Capacidad, Estatus) VALUES (@Nombre, @Lugar, @FechaHora, @Categoria, @Capacidad, @Estatus);";

                    // Crea un objeto de comando SQL, asociándolo con la consulta y la conexión
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        // Asigna los valores de los parámetros recibidos a los parámetros de la consulta SQL
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Lugar", lugar);
                        comando.Parameters.AddWithValue("@FechaHora", fechahora);
                        comando.Parameters.AddWithValue("@Categoria", tipo);
                        comando.Parameters.AddWithValue("@Capacidad", capacidad);
                        comando.Parameters.AddWithValue("@Estatus", estatus);

                        // Ejecuta el comando, ExecuteNonQuery() se usa para operaciones que no devuelven datos (INSERT, UPDATE, DELETE)
                        // y retorna el número de filas afectadas
                        int filasAfectadas = comando.ExecuteNonQuery();

                        // Devuelve 'true' si la operación fue exitosa (si se insertó al menos una fila)
                        return filasAfectadas > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine("Error al agregar evento: " + ex.Message);
                    // Devuelve 'false' para indicar que la operación falló
                    return false;
                }
                catch (Exception ex)
                {
                    // Captura cualquier otro error inesperado
                    Debug.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                    return false;
                }
            }
        }

        #endregion

        #region READ (Listar)

        // Este método obtiene todos los registros de la tabla Evento
        public DataTable ListarTodos()
        {
            // Crea una DataTable, que es como una tabla en memoria para almacenar los resultados
            var tabla = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();

                // SqlDataAdapter es ideal para leer datos. Se encarga de abrir la conexión,
                // ejecutar el SELECT y llenar la DataTable
                using (var adapter = new SqlDataAdapter("SELECT * FROM Evento;", conn))
                {
                    // El método Fill ejecuta la consulta y vuelca todos los resultados en la tabla
                    adapter.Fill(tabla);
                }
            }
            // Devuelve la tabla llena de datos a la capa que lo llamó (la capa de negocios)
            return tabla;
        }

        #endregion

        #region UPDATE (Modificar)

        // Este método modifica un evento existente en la base de datos, identificado por su ID
        public bool Modificar(int id, string nombre, string lugar, DateTime fechahora, string tipo, int capacidad, string estatus)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    // Define la consulta SQL para la actualización, usando el ID en la cláusula WHERE
                    string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, FechaHora = @FechaHora, Categoria = @Categoria, Capacidad = @Capacidad, Estatus = @Estatus WHERE Id = @Id;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Asigna todos los parámetros, incluyendo el ID para el WHERE
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Lugar", lugar);
                        cmd.Parameters.AddWithValue("@FechaHora", fechahora);
                        cmd.Parameters.AddWithValue("@Categoria", tipo);
                        cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                        cmd.Parameters.AddWithValue("@Estatus", estatus);

                        // Ejecuta el comando y obtiene el número de filas modificadas
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        // Devuelve 'true' si se modificó al menos una fila
                        return filasAfectadas > 0;
                    }
                }
                catch (SqlException ex)
                {

                    Debug.WriteLine("Error de SQL al modificar evento: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    // Captura cualquier otra excepción inesperada
                    Debug.WriteLine("Ocurrió un error inesperado al modificar evento: " + ex.Message);
                    return false;
                }
            }
        }

        #endregion

        #region DELETE (Eliminar)

        // Este método elimina un evento de la base de datos usando su ID
        public bool Eliminar(int id)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    // Define la consulta SQL para la eliminación
                    var query = "DELETE FROM Evento WHERE Id = @Id;";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        // Asigna el ID del evento a eliminar
                        cmd.Parameters.AddWithValue("@Id", id);
                        // Ejecuta el comando
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        // Devuelve 'true' si se eliminó al menos una fila
                        return filasAfectadas > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine("Error de SQL al eliminar evento: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Ocurrió un error inesperado al eliminar evento: " + ex.Message);
                    return false;
                }
            }
        }

        #endregion
    }
}