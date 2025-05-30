using System;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Eventos
    {
        //Atributos de la clase eventos para ser heredados en otras clases
        public int Id;
        public string Fecha;
        public string Nombre;
        public string Lugar;
        public string Tipo;
    }

    //Clases CULTURAL Y DEPORTIVO para heredar de la clase EVENTOS sus atributos 

    public class Cultural : Eventos
    {
        public string Feria = "UCE - Recinto Punta Cana";
    }

    public class Deportivo : Eventos
    {
        public string Torneo = "Parque San Juan";
    }

    public class EventosDatos
    {
        //Cadena de conexion a SQL Server 
        public string conexion = "Server=.;Database=Eventos;Integrated Security=true" + " ;TrustServerCertificate=True;";

        //Metodo usado para obtener Eventos por su Id
        public Eventos ObtenerResumenEvento(int idBusqueda)
        {
            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open(); //Abre la conexion con la base de datos

                //Consulta SQL para buscar por ID
                string query = "SELECT * FROM Eventos WHERE Id = @Id";

                //Comando SQL y agregacion del parametro de busqueda 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idBusqueda);

                //Ejecutando la consulta
                SqlDataReader reader = cmd.ExecuteReader();

                //Verifica si hay resultados
                if (reader.Read())
                {
                    //Se determina el tipo de evento

                    string tipo = reader["Tipo"].ToString();
                    Eventos eventos = tipo == "Cultural" ? new Cultural() : new Deportivo();

                    //Si es un evento cultural, se instancia Cultural
                    if (tipo == "Cultural")
                        eventos = new Cultural();
                    else
                        //Si es un evento deportivo, se instancia Deportivo
                        eventos = new Deportivo();

                    //Se asignan valores desde la base
                    //de datos a los atributos de la clase
                    eventos.Id = (int)reader["Id"];
                    eventos.Fecha = reader["Fecha"].ToString();
                    eventos.Nombre = reader["Nombre"].ToString();
                    eventos.Lugar = reader["Lugar"].ToString();
                    eventos.Tipo = tipo;

                    return eventos; //Devuelve el evento encontrado 
                }

                return null; //Si no se encuentra, devuelve null
            }
        }

        public Eventos ObtenerEventosPorTipo(string tipo)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT TOP 1 * FROM Evento WHERE Tipo = @Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Eventos eventos = tipo == "Cultural"? new Cultural() : new Deportivo();

                    eventos.Id = (int)reader["Id"];
                    eventos.Nombre = reader["Nombre"].ToString();
                    eventos.Lugar = reader["Lugar"].ToString();
                    eventos.Fecha = reader["Fecha"].ToString();
                    eventos.Tipo = tipo;

                    return eventos;
                }

                return null; 
            }
        }

    }

}
