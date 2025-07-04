using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CRUD : ConnectionToSql
    {

        // CREATE: Recibe los datos simples y los inserta en la base de datos
        public void Agregar(string nombre, string lugar, DateTime fecha, string tipo, int capacidad)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                // Tu consulta SQL para la tabla Evento.
                // Asegúrate que tu tabla tenga una columna 'Categoria' y no 'Tipo'.
                string query = "INSERT INTO Evento (Nombre, Lugar, Fecha, Categoria, Capacidad) VALUES (@Nombre, @Lugar, @Fecha, @Categoria, @Capacidad);";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Lugar", lugar);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Categoria", tipo);
                    comando.Parameters.AddWithValue("@Capacidad", capacidad);
                    comando.ExecuteNonQuery();
                }
            }
        }


        // READ: Devuelve un DataTable, no una lista de objetos
        public DataTable ListarTodos()
        {
            DataTable tabla = new DataTable();
            // Usamos el método GetConnection() heredado
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Evento;";
                using (SqlCommand comand = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comand);
                    adapter.Fill(tabla); // Llenamos el DataTable con los resultados
                }
            }
            return tabla;
        }

        // UPDATE: Recibe todos los datos, incluyendo el ID, para modificar un registro que ya existia
        public void Modificar(int id, string nombre, string lugar, DateTime fecha, string tipo, int capacidad)
        {
            // Usamos el método GetConnection() heredado.
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, Fecha = @Fecha, Categoria = @Categoria, Capacidad = @Capacidad WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Lugar", lugar);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Categoria", tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE: Recibe un ID y elimina el registro correspondiente.
        public void Eliminar(int id)
        {
            // Usamos el método GetConnection() heredado.
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Evento WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}