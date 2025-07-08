// Propósito: Definir la ESTRUCTURA y las PROPIEDADES comunes a todos los eventos
// Esta clase es abstracta y servirá como base para otros tipos de eventos, como Cultural y Deportivo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    //TODO Requisito: creación de una clase abstracta
    public abstract class EventoBase
    {
        //Atributos de la clase eventos para ser heredados en otras clases
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Nombre { get; set; }
        public string? Lugar { get; set; }
        public string? Categoria { get; set; }
        public int Capacidad { get; set; } //Capacidad del evento
        public string Estatus { get; set; } = "Planificado";



        //TODO Requisito: Método virtual que las clases hijas PUEDEN sobrescribir si quieren
        public virtual string ObtenerLema()
        {
            return "¡Un evento para todos!";
        }

        //TODO Requisito: Método abstracto que las clases hijas DEBEN implementar
        public abstract string MiPatrocinadorFav();
    }
}


