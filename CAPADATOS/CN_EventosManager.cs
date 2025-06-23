using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos; 
using CAPA_DE_CAPAS; 

namespace CAPA_DE_NEGOCIOS 
{
   public class CN_EventosManager // Propósito: Contener la lógica de negocio y las reglas para manejar los eventos.
   {
        private CRUD e = new CRUD();

        //Metodos tipo CRUD
        public List<EventoBase> ObtenerTodosLosEventos() { /* ... */ } //READ
        public void GuardarEvento(EventoBase evento) { /* ... */ } //CREATE & UPDATE
        public void EliminarEvento(int id) { /* ... */ } //DELETE

        public string ObtenerDetalles(EventoBase evento)
        {
            string resumen = $"El evento '{evento.Nombre}' se realizará en {evento.Lugar}.";
            string fechaFormateada = ObtenerFechaBien(evento.Fecha);

            // Usamos un 'switch' sobre el tipo de objeto para dar un mensaje personalizado
            switch (evento)
            {
                case Deportivo d:
                    return $"{resumen} Este evento deportivo se llevará a cabo el {fechaFormateada} y tendrá una capacidad de {d.Capacidad} personas.";
                case Cultural c:
                    return $"{resumen} Este evento cultural se celebrará el {fechaFormateada} y cuenta con una capacidad de {c.Capacidad} asistentes.";
                case Profesional p:
                    return $"{resumen} Este evento profesional se celebrará el {fechaFormateada} y cuenta con una capacidad de {p.Capacidad} asistentes.";
                case Tecnologico t:
                    return $"{resumen} Este evento tecnologico se celebrará el {fechaFormateada} y cuenta con una capacidad de {t.Capacidad} asistentes.";
                case Cinematografico cine:
                    return $"{resumen} Este evento cinematografico se celebrará el {fechaFormateada} y cuenta con una capacidad de {cine.Capacidad} asistentes.";

                default:
                    return $"{resumen} Fecha: {fechaFormateada}. Capacidad: {evento.Capacidad}.";
            }
        }
        public string ObtenerFechaBien(DateTime fecha)
        {
            // Este método recibe la fecha como parámetro
            return fecha.ToString("d 'de' MMMM 'del' crocodiles 'a las' hh:mm tt");
        }

    }
}
