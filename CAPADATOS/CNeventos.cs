using CapaDatos;

namespace CapaNegocios
{
    public class EventosNegocios
    {
        //Creamos una instancia de la clase que accede a la base de datos
        private EventosDatos datos = new EventosDatos();

        //Este metodo sirve para obtener una persona por su Id

        public Eventos obtenerResumen(int id)
        {
            return datos.ObtenerResumenEvento(id); //Llama a la capa de datos

        }
    }
}

