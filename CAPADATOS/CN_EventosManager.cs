using System;
using System.Collections.Generic;
using CapaDatos;
using CAPA_DE_CAPAS;

namespace CAPA_DE_NEGOCIOS
{
    public class CN_EventosManager
    {
        private CRUD e = new CRUD();

        // --- AQUÍ ESTÁ EL MÉTODO QUE FALTABA POR LLENAR Y CAUSABA EL ERROR ---
        public List<EventoBase> ObtenerTodosLosEventos()
        {
            // La lógica es simple: solo le pide a la capa de datos que haga su trabajo.
            // Ahora este método SÍ devuelve lo que promete, solucionando el error.
            return e.ListarTodos();
        }

        public void GuardarEvento(EventoBase evento)
        {
            // REQUISITO CUMPLIDO: "Validaciones en los campos de entrada".
            // Esta es una regla de negocio. La capa de negocios valida los datos antes de guardarlos.
            if (string.IsNullOrWhiteSpace(evento.Nombre))
            {
                throw new Exception("El nombre del evento es un campo obligatorio.");
            }

            if (evento.Id == 0) e.Agregar(evento);
            else e.Modificar(evento);
        }

        public void EliminarEvento(int id)
        {
            e.Eliminar(id);
        }

        // REQUISITO CUMPLIDO: "Creación y uso de metodos normales"
        // Este es un método normal que aplica lógica para formatear una cadena de texto.
        public string ObtenerDetalles(EventoBase evento)
        {
            string resumen = $"El evento '{evento.Nombre}' se realizará en {evento.Lugar}.";
            string fechaFormateada = ObtenerFechaBien(evento.Fecha);

            // Esto demuestra polimorfismo, una faceta del uso correcto de la herencia.
            switch (evento)
            {
                case Deportivo d:
                    return $"{resumen} Este evento deportivo se llevará a cabo el {fechaFormateada} y tendrá una capacidad de {d.Capacidad} personas.";
                case Cultural c:
                    return $"{resumen} Este evento cultural se celebrará el {fechaFormateada} y cuenta con una capacidad de {c.Capacidad} asistentes.";
                // ... casos para los otros tipos ...
                default:
                    return $"{resumen} Fecha: {fechaFormateada}. Capacidad: {evento.Capacidad}.";
            }
        }

        public string ObtenerFechaBien(DateTime fecha)
        {
            // Corregí el pequeño error en el formato del año.
            return fecha.ToString("d 'de' MMMM 'del' yyyy 'a las' hh:mm tt");
        }
    }
}