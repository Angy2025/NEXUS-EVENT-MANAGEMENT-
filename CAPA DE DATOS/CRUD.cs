using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CRUD : ConnectionToSql
    {
        #region Métodos Públicos (CRUD)


        // CREATE: Inserta un nuevo evento en la base de datos

        public void Agregar(string nombre, string lugar, DateTime fechahora,string tipo, int capacidad)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Evento (Nombre, Lugar, Fecha, Hora, Categoria, Capacidad) VALUES (@Nombre, @Lugar, @Fecha, @Categoria, @Capacidad);";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Lugar", lugar);
                    comando.Parameters.AddWithValue("@Fecha", fechahora);    
                    comando.Parameters.AddWithValue("@Categoria", tipo);
                    comando.Parameters.AddWithValue("@Capacidad", capacidad);
                    comando.ExecuteNonQuery();
                }
            }
        }


        // READ: Obtiene todos los eventos de la BD
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

        // UPDATE: Modifica un evento existente 
        public void Modificar(int id, string nombre, string lugar, DateTime fechahora, string tipo, int capacidad)
        {
            // Usamos el método GetConnection() heredado
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, FechaHora = @FechaHora,  Categoria = @Categoria, Capacidad = @Capacidad WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Lugar", lugar);
                    cmd.Parameters.AddWithValue("@Fecha", fechahora);
                    cmd.Parameters.AddWithValue("@Categoria", tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE: Recibe un ID y elimina el registro correspondiente

        public void Eliminar(int id)
        {
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

        #endregion
    }
}