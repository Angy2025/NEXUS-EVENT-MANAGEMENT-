using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    //TODO Requisito: Herencias
    public class CRUD : ConnectionToSql
    {
        #region Métodos Públicos (CRUD)


        // CREATE: Inserta un nuevo evento en la base de datos

        public void Agregar(string nombre, string lugar, DateTime fechahora,string tipo, int capacidad, string estatus)
        {
            using (var conn = GetConnection())
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
                    comando.ExecuteNonQuery();
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
        public void Modificar(int id, string nombre, string lugar, DateTime fechahora, string tipo, int capacidad, string estatus)
        {
            // Usamos el método GetConnection() heredado
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, FechaHora = @FechaHora,  Categoria = @Categoria, Capacidad = @Capacidad, Estatus = @Estatus WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Lugar", lugar);
                    cmd.Parameters.AddWithValue("@FechaHora", fechahora);
                    cmd.Parameters.AddWithValue("@Categoria", tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@Estatus", estatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE: Recibe un ID y elimina el registro correspondiente

        public void Eliminar(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM Evento WHERE Id = @Id;";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}