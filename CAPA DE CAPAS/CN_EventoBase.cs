// Propósito: Definir la ESTRUCTURA y las PROPIEDADES comunes a todos los eventos
// Esta clase es abstracta y servirá como base para otros tipos de eventos, como Cultural y Deportivo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_CAPAS
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

    }
}
