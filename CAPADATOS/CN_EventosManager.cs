using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using Microsoft.Identity.Client;

namespace CAPA_DE_NEGOCIOS
{
    public class CN_EventosManager
    {
        private CRUD _crud = new CRUD();

        // Constructor que recibe un objeto CRUD para interactuar con la base de datos
        public CN_EventosManager(CRUD manejadorCrud)
        {
            _crud = manejadorCrud;
        }
        // READ: Este método contiene la lógica de traducción
        public List<EventoBase> ObtenerTodosLosEventos()
        {
            //Pide los datos GENÉRICOS a la capa de datos
            return _crud.ListarTodos();
        }

            public void GuardarEvento(EventoBase evento)
            {
            //Antes de guardar, validamos que el evento tenga los datos necesarios
            if (string.IsNullOrWhiteSpace(evento.Nombre))
            {
                throw new Exception("El nombre del evento es obligatorio");
            }

            if (evento.Capacidad <= 0)
            {
                throw new Exception("La capacidad debe ser un numero mayor a cero");
            }

            if (evento.Id == 0)
            {
                // Si el Id es 0, es un nuevo evento, lo agregamos
                _crud.Agregar(evento.Nombre, evento.Lugar, evento.Fecha, evento.Tipo, evento.Capacidad);
            }
            else
            {
                // Si el Id no es 0, actualizamos el evento existente
                _crud.Modificar(evento.Id, evento.Nombre, evento.Lugar, evento.Fecha, evento.Tipo, evento.Capacidad);
            }
            
            }

                public void EliminarEvento(int id)
                {
                    // Validamos que el ID sea mayor a cero
                    if (id <= 0)
                    {
                        throw new Exception("El ID del evento para eliminar no es valido ");
                    }
                        _crud.Eliminar(id);
                }

        public string ObtenerDetalles(EventoBase evento)
        {
            string resumen = $"El evento '{evento.Nombre}' se realizará en {evento.Lugar}.";
            string fechaFormateada = ObtenerFechaBien(evento.Fecha);

            switch (evento)
            {
                case Deportivo d:
                    return $"{resumen} Este evento deportivo se llevará a cabo el {fechaFormateada} y tendrá una capacidad de {d.Capacidad} personas.";
                case Cultural c:
                    return $"{resumen} Este evento cultural se celebrará el {fechaFormateada} y cuenta con una capacidad de {c.Capacidad} asistentes.";
                case Profesional p:
                    return $"{resumen} Este evento profesional se celebrará el {fechaFormateada} y cuenta con una capacidad de {p.Capacidad} asistentes.";
                case Tecnologico t:
                    return $"{resumen} Este evento tecnológico se celebrará el {fechaFormateada} y cuenta con una capacidad de {t.Capacidad} asistentes.";
                case Cinematografico cine:
                    return $"{resumen} Este evento cinematográfico se celebrará el {fechaFormateada} y cuenta con una capacidad de {cine.Capacidad} asistentes.";
                default:
                    return $"{resumen} Fecha: {fechaFormateada}. Capacidad: {evento.Capacidad}.";
            }
        }

        public string ObtenerFechaBien(DateTime fecha)
        {
            return fecha.ToString("d 'de' MMMM 'del' crocodiles 'a las' hh:mm tt");
        }
    }
 }

