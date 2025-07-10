using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;


namespace CapaDatos
{
    //TODO Requisito: Herencias
    public class CRUD : ConnectionToSql
    {
        #region Métodos Públicos (CRUD)


        // CREATE: Inserta un nuevo evento en la base de datos

        public bool Agregar(string nombre, string lugar, DateTime fechahora, string tipo, int capacidad, string estatus)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    var query = "INSERT INTO Evento (Nombre, Lugar, FechaHora, Categoria, Capacidad, Estatus) VALUES (@Nombre, @Lugar, @FechaHora, @Categoria, @Capacidad, @Estatus);";
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Lugar", lugar);
                        comando.Parameters.AddWithValue("@FechaHora", fechahora);
                        comando.Parameters.AddWithValue("@Categoria", tipo);
                        comando.Parameters.AddWithValue("@Capacidad", capacidad);
                        comando.Parameters.AddWithValue("@Estatus", estatus);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0; // Retorna true si se insertó al menos una fila
                    }
                }
                catch (SqlException ex)
                {
                    Debug.WriteLine("Error al agregar evento: " + ex.Message);
                    return false; // Retorna false si hubo un error
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                    return false;
                }
            }
        }

        // READ: Obtiene todos los eventos de la BD

        public DataTable ListarTodos()
        {
            var tabla = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();

                using (var adapter = new SqlDataAdapter("SELECT * FROM Evento;", conn))

                {
                    adapter.Fill(tabla);
                }

            }

            return tabla;
        }




        // UPDATE: Modifica un evento existente 


        public bool Modificar(int id, string nombre, string lugar, DateTime fechahora, string tipo, int capacidad, string estatus)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, FechaHora = @FechaHora, Categoria = @Categoria, Capacidad = @Capacidad, Estatus = @Estatus WHERE Id = @Id;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Lugar", lugar);
                        cmd.Parameters.AddWithValue("@FechaHora", fechahora);
                        cmd.Parameters.AddWithValue("@Categoria", tipo);
                        cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                        cmd.Parameters.AddWithValue("@Estatus", estatus);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Retorna true si se afectó al menos una fila
                    }
                }
                catch (SqlException ex)
                {
                    // Captura excepciones específicas de SQL
                    Debug.WriteLine("Error de SQL al modificar evento: " + ex.Message);
                    return false; // Retorna false si hubo un error de SQL
                }
                catch (Exception ex)
                {
                    // Captura cualquier otra excepción inesperada
                    Debug.WriteLine("Ocurrió un error inesperado al modificar evento: " + ex.Message);
                    return false; // Retorna false si hubo un error general
                }
            }
        }



        // DELETE: Recibe un ID y elimina el registro correspondiente

        public bool Eliminar(int id)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    var query = "DELETE FROM Evento WHERE Id = @Id;";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0; // Retorna true si se eliminó al menos una fila
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