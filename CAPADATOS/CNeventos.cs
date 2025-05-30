using CapaDatos;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Tracing;

namespace CapaNegocios
{
    public class EventosNegocios
    {
        //Creamos una instancia de la clase que accede a la base de datos
        private EventosDatos datos = new EventosDatos();
     
        public Eventos ObtenerEventosPorTipo(string tipo)
        {
            if (tipo != "Cultural" && tipo != "Deportivo")
                return null; 

            return datos.ObtenerEventosPorTipo(tipo);
        }
    }
}

