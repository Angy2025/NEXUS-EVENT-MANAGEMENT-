using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CAPA_DE_NEGOCIOS;

namespace CAPA_DE_NEGOCIOS
{
    public class CN_EventosManager
    {
        private CRUD _crud = new CRUD();

        // READ: Este método contiene la lógica de traducción
        public List<EventoBase> ObtainAllEvents()
        {
            //Pide los datos GENÉRICOS a la capa de datos
            DataTable tablaDeDatos = _crud.ListarTodos();

            // Lista para almacenar los eventos
            List<EventoBase> lista = new List<EventoBase>();

            // Recorre cada fila del DataTable
            foreach (DataRow fila in tablaDeDatos.Rows)
            {
                string tipo = fila["Tipo"].ToString();
                EventoBase evento;

                //TODO Requisito: Uso de herencia y sus constructores, aqui voy a crear el objeto correcto basado en el tipo de evento
                switch (tipo)
                {
                    case "Deportivo":
                        evento = new Deportivo();
                        break;
                    case "Cultural":
                        evento = new Cultural();
                        break;
                    case "Tecnológico":
                        evento = new Tecnologico();
                        break;
                    case "Cinematográfico":
                        evento = new Cinematografico();
                        break;
                    case "Profesional":
                        evento = new Profesional();
                        break;
                    default: continue; // Si el tipo no es reconocido, saltamos a la siguiente iteración
                }

                // Asignamos los valores de la fila a las propiedades del evento
                evento.Id = Convert.ToInt32(fila["Id"]);
                evento.Nombre = fila["Nombre"].ToString();
                evento.Lugar = fila["Lugar"].ToString();
                evento.Fecha = Convert.ToDateTime(fila["Fecha"]);
                evento.Capacidad = Convert.ToInt32(fila["Capacidad"]);

                lista.Add(evento); // Agregamos el evento a la lista
            }

            return lista;
        }

        // CREATE: Este método recibe un objeto EventoBase y lo agrega a la base de datos
        public void AddEvent(EventoBase evento)
        {
            //TODO Requisito: Validar que el evento no sea nulo
            if (string.IsNullOrWhiteSpace(evento.Nombre))
            {
                throw new Exception("El nombre del evento es obligatorio para esta accion");
            }
            if (evento.Id == 0)
            {
                //Llamar al método de la capa de datos para agregar el evento
                _crud.Agregar(evento.Nombre, evento.Lugar, evento.Fecha, evento.Tipo, evento.Capacidad);
            }
            else
            {
                //Llamamos al metodo modificar (tambien de la capa de datos)
                _crud.Modificar(evento.Id, evento.Nombre, evento.Lugar, evento.Fecha, evento.Tipo, evento.Capacidad);
            }
        }

        //DELETE 
        public void EliminarEvento(int id)
        {
            if (id <= 0)
            {
                throw new Exception("El ID del evento que quieres eliminar no es valido");
            }
            _crud.Eliminar(id);
        }

    }
}

