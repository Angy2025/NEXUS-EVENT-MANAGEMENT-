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

        //CREATE: Este primer método recibe un objeto de evento y lo inserta como un nuevo registro en mi base de datos
        public void Agregar(EventoBase evento)
        {
            // El bloque 'using' asegura que la conexión se cierre siempre
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO Evento (Nombre, Lugar, Fecha, Tipo, Capacidad) VALUES (@Nombre, @Lugar, @Fecha, @Tipo, @Capacidad);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignamos los valores del objeto a los parámetros de la consulta SQL
                    cmd.Parameters.AddWithValue("@Nombre", evento.Nombre);
                    cmd.Parameters.AddWithValue("@Lugar", evento.Lugar);
                    cmd.Parameters.AddWithValue("@Fecha", evento.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", evento.Tipo);
                    cmd.Parameters.AddWithValue("@Capacidad", evento.Capacidad);

                    // Ejecutamos el comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //READ: Este método obtiene todos los eventos de la base de datos y los devuelve como una lista de EventoBase
        public List<EventoBase> ListAll()
        {
            // Aqui creo una lista vacía que se va a llenar
            List<EventoBase> listaEventos = new List<EventoBase>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Lugar, Fecha, Tipo, Capacidad FROM Evento ORDER BY Fecha;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Se lee el resultado fila por fila
                    while (reader.Read())
                    {
                        // Y se convierte cada fila en un objeto (agregandolo a la lista)
                        listaEventos.Add(MapearEventoDesdeReader(reader));
                    }
                }
            }
            return listaEventos;

        }







}
