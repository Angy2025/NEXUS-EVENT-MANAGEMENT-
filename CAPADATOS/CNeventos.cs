using CapaDatos;
using Microsoft.Data.SqlClient; //Necesario para trabajar con SQL Server
using System.Collections.Generic; //Necesario para List

namespace CapaNegocios
{
    public class Eventos
    {
        //Atributos de la clase eventos para ser heredados en otras clases
        public int Id { get; set; }
        public string Fecha { get; set; } //Para la manipulacion de objetos
        public string Nombre { get; set; }
        public string Lugar { get; set; }
            public string Tipo { get; set; }
    }

        //Clases CULTURAL Y DEPORTIVO para heredar de la clase EVENTOS sus atributos 
        public class Cultural : Eventos
        {
            public Cultural() { } //No puse un tipo aqui porque ya lo asigne en la base de datos
        }
        public class Deportivo : Eventos
        {
            public Deportivo() { } //Lo mismo pasa aqui que en la subclase Cultural
        }

         //Ahora cree una clase que maneje la logica de negocio e interpretacion con mi Base de Datos Eventos
        public class EventosManager
        {
        private string cadenaConexion;

          public EventosManager()
        {
            EventosDatos datosConexion = new EventosDatos(); //Instanciamos la clase EventosDatos para obtener la cadena de conexion
            cadenaConexion = datosConexion.conexion;
        }
        //Metodo usado para obtener un Eventos por su Id
        public Eventos ObtenerResumenEvento(int idBusqueda)
        {
            //Se abre la conexion
            EventosDatos datos = new EventosDatos();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open(); 

                //Consulta SQL para buscar por ID
                string query = "SELECT Id, Fecha, Nombre, Lugar, Tipo FROM Eventos WHERE Id = @Id";

                //Comando SQL y agregacion del parametro de busqueda 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idBusqueda);

                //Se ejecuta la consulta y se verifica si hay resultados
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //Se determina el tipo de evento
                    string tipoEvento = reader["Tipo"].ToString();
                    Eventos eventos;

                    //Si es un evento cultural, se instancia Cultural
                    if (tipoEvento == "Cultural")
                    {
                        eventos = new Cultural();
                    }
                    else if (tipoEvento == "Deportivo")
                    {
                        //Si es un evento deportivo, se instancia Deportivo
                        eventos = new Deportivo();
                    }
                    else
                    {
                        eventos = new Eventos();
                    }

                    //Se asignan valores desde la base de datos a los atributos de la clase
                    eventos.Id = (int)reader["Id"];
                    eventos.Fecha = reader["Fecha"].ToString();
                    eventos.Nombre = reader["Nombre"].ToString();
                    eventos.Lugar = reader["Lugar"].ToString();
                    eventos.Tipo = tipoEvento;

                    return eventos;
                }
            }

            return null; 
        }

        public List<Eventos> ObtenerEventosPorTipo(string tipo)
        {
            List<Eventos> listaEventos = new List<Eventos>();

                if (tipo != "Cultural" && tipo != "Deportivo")
            {
                return listaEventos; //Devuelve una lista vacia si el tipo no es valido
            }

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT Id, Fecha, Nombre, Lugar, Tipo FROM Evento WHERE Tipo = @Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo); 

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) //Anadi un whilw para que lea todos los registros
                {
                    string tipoEvento = reader["Tipo"].ToString();
                    Eventos eventos; 

                    if (tipoEvento == "Cultural")
                    {
                        eventos = new Cultural();
                    }
                    else if (tipoEvento == "Deportivo")
                    {
                        eventos = new Deportivo(); 
                    }
                    else
                    {
                        eventos = new Eventos();
                    }

                    eventos.Id = (int)reader["Id"];
                    eventos.Fecha = reader["Fecha"].ToString();
                    eventos.Nombre = reader["Nombre"].ToString();
                    eventos.Lugar = reader["Lugar"].ToString();
                    eventos.Tipo = tipoEvento; 

                    listaEventos.Add(eventos);
                }
            }
                return listaEventos;
        }
        }
  
}

