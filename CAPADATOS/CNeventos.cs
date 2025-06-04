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
        private string CadenaConexion;

          public EventosManager()
        {
            EventosDatos datosConexion = new EventosDatos(); //Instanciamos la clase EventosDatos para obtener la cadena de conexion
            CadenaConexion = datosConexion.CadenaConexion;
        }







        //Metodo usado para obtener un Eventos por su Id
        public Eventos ObtenerResumenEvento(int idBusqueda)
        {
            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open(); 

                //Consulta SQL para buscar por ID
                string query = "SELECT Id, Fecha, Nombre, Lugar, Tipo FROM Evento WHERE Id = @Id";

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

                    reader.Close();
                    return eventos;
                }
            }

            return null; 
        }



        //Metodo para obtener todos los eventos segun su tipo (Cultural o Deportivo)
        public List<Eventos> ObtenerEventosPorTipo(string tipo)
        {
            List<Eventos> listaEventos = new List<Eventos>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evento WHERE Tipo = @Tipo", conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) //Anadi un while para que lea todos los registros
                {
                    Eventos eventos = new Eventos
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Fecha = reader["Fecha"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Lugar = reader["Lugar"].ToString(),
                        Tipo = reader["Tipo"].ToString()
                    };

                    listaEventos.Add(eventos); //Agregamos cada objeto a la lista
                }

                reader.Close(); //Cerramos el lector
            }

            return listaEventos; //Retornamos la lista final de eventos
        }

    }

}

