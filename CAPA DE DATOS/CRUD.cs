// Propósito: Esta clase es la ÚNICA responsable de todas las operaciones de la base de datos (CRUD)
using CAPA_DE_CAPAS; // Importamos la capa de capas para usar EventoBase y sus derivados
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;


namespace CapaDatos
{
    public class CRUD
    {
        private readonly string CadenaConexion;

        public CRUD()
        {
            EventosDatos datosDeConexion = new EventosDatos();  // Instancia de la clase EventosDatos para obtener la cadena de conexión del otro archivo
            CadenaConexion = datosDeConexion.ObtenerConexion();
        }

        // CREATE: Añade un nuevo evento a la base de datos.
        public void Agregar(EventoBase evento)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO Evento (Nombre, Lugar, Fecha, Tipo, Capacidad) VALUES (@Nombre, @Lugar, @Fecha, @Tipo, @Capacidad);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", evento.Nombre);
                    cmd.Parameters.AddWithValue("@Lugar", evento.Lugar);
                    cmd.Parameters.AddWithValue("@Fecha", evento.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", evento.Tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", evento.Capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //READ: Lee todos los eventos y los devuelve como una lista de objetos.
        //REQUISITO CUMPLIDO: "Uso de listas para almacenamiento temporal".
        //La información de la BD se almacena temporalmente en esta lista de objetos antes de pasarla a otra capa.
        public List<EventoBase> ListarTodos()
        {
            List<EventoBase> listaEventos = new List<EventoBase>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Lugar, Fecha, Tipo, Capacidad FROM Evento ORDER BY Fecha;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Aquí llamamos al método que traduce la fila de la BD a un objeto.
                        listaEventos.Add(MapearEventoDesdeReader(reader));
                    }
                }
            }
            return listaEventos;
        }

         // --- AQUÍ ESTÁ EL MÉTODO QUE FALTABA Y CAUSABA EL ERROR ---
        // Este método privado convierte una fila de SQL en un objeto de C#.
        private EventoBase MapearEventoDesdeReader(SqlDataReader reader)
        {
            string tipoEvento = reader["Tipo"].ToString();
            EventoBase evento;

            // REQUISITO CUMPLIDO: "Creación y uso de herencias de forma correcta" y "Creación y uso de constructores".
            // Usamos un 'switch' para decidir qué clase hija instanciar.
            // Al hacer "new Deportivo()", estamos usando el constructor de esa clase hija.
            switch (tipoEvento)
            {
                case "Deportivo": evento = new Deportivo(); break;
                case "Cultural": evento = new Cultural(); break;
                case "Tecnológico": evento = new Tecnologico(); break;
                case "Cinematográfico": evento = new Cinematografico(); break;
                case "Profesional": evento = new Profesional(); break;
                default:
                    throw new Exception($"Tipo de evento '{tipoEvento}' no reconocido.");
            }

            // Llenamos las propiedades del objeto creado.
            evento.Id = (int)reader["Id"];
            evento.Nombre = reader["Nombre"].ToString();
            evento.Lugar = reader["Lugar"].ToString();
            evento.Fecha = (DateTime)reader["Fecha"];
            evento.Capacidad = (int)reader["Capacidad"];

            return evento;
        }

        // UPDATE: Modifica un registro existente.
        public void Modificar(EventoBase evento)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string query = "UPDATE Evento SET Nombre = @Nombre, Lugar = @Lugar, Fecha = @Fecha, Tipo = @Tipo, Capacidad = @Capacidad WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", evento.Id);
                    cmd.Parameters.AddWithValue("@Nombre", evento.Nombre);
                    cmd.Parameters.AddWithValue("@Lugar", evento.Lugar);
                    cmd.Parameters.AddWithValue("@Fecha", evento.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", evento.Tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", evento.Capacidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE: Elimina un registro por su ID.
        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
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
