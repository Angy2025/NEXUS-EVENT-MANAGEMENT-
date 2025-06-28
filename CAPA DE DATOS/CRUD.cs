using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CRUD
    {
        private EventosDatos conexion = new EventosDatos();

        // CREATE: Recibe los datos simples y los inserta en la base de datos
        public void Agregar(string nombre, string lugar, DateTime fecha, string tipo, int capacidad)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerConexion()))
            {
                conn.Open();
                string query = "INSERT INTO Evento (Nombre, Lugar, Fecha, Tipo, Capacidad) VALUES (@Nombre, @Lugar, @Fecha, @Tipo, @Capacidad);";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Lugar", lugar);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Tipo", tipo);
                    comando.Parameters.AddWithValue("@Capacidad", capacidad);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // READ: Devuelve un DataTable, no una lista de objetos
        public DataTable ListarTodos()
        {
            DataTable tabla = new DataTable();
            //Usamos SqlConnection para conectarnos a la base de datos
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerConexion()))
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
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerConexion()))
            {
                conn.Open();
                string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, Fecha = @Fecha, Tipo = @Tipo, Capacidad = @Capacidad WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Es crucial pasar el ID en la cláusula WHERE para saber qué fila modificar.
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Lugar", lugar);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // DELETE: Recibe un ID y elimina el registro correspondiente.
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerConexion()))
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