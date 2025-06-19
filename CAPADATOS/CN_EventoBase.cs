using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public abstract class EventoBase
    {
        //Atributos de la clase eventos para ser heredados en otras clases
        public int Id { get; set; }
        public DateTime Fecha { get; set; } 
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; } //Capacidad del evento


        public virtual string ObtenerResumenEvento()
        {
            return $"El evento '{Nombre}' se realizara en {Lugar}.";
        }

        public abstract string ObtenerDetalles();


        public string ObtenerFechaBien()
        {
            return Fecha.ToString("d 'de' MMM 'del' yyyy 'a las' hh:mm tt");
        }
    }
}
