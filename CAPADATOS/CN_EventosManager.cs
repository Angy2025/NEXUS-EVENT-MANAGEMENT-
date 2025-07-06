using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CAPA_DE_ENTIDADES.CACHE;

namespace CAPA_DE_NEGOCIOS
{
    public class CN_EventosManager
    {
        private CRUD _crud = new CRUD();

        // READ: Este método contiene la lógica de traducción
        public List<EventoBase> ObtainAllEvents()
        {
            //Pide los datos genericos a la capa de datos

            DataTable tablaDeDatos = _crud.ListarTodos();
            List<EventoBase> lista = new List<EventoBase>();

            // Recorre cada fila del DataTable

            foreach (DataRow fila in tablaDeDatos.Rows)
            {
                string tipo = fila["Categoria"].ToString();
                EventoBase evento;

                //TODO Requisito: Uso de herencia y sus constructores

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
                    default: 
                        continue; // Si el tipo no es reconocido, saltamos a la siguiente iteración
                }

                // Asignamos los valores de la fila a las propiedades del evento

                evento.Id = Convert.ToInt32(fila["Id"]);
                evento.Nombre = fila["Nombre"].ToString();
                evento.Lugar = fila["Lugar"].ToString();
                evento.FechaHora = Convert.ToDateTime(fila["FechaHora"]);
                evento.Capacidad = Convert.ToInt32(fila["Capacidad"]);

                lista.Add(evento);
            }

            return lista;
        }

        // CREATE: Este método recibe un objeto EventoBase y lo agrega a la base de datos

        public void AddEvent(EventoBase evento)
        {
            //TODO Requisito: Validacion de datos

            if (string.IsNullOrWhiteSpace(evento.Nombre))
            {
                throw new Exception("El nombre del evento es obligatorio");
            }

            // Lógica para decidir si es un evento nuevo (Agregar) o existente (Modificar)

            if (evento.Id == 0)
            {
                _crud.Agregar(evento.Nombre, evento.Lugar, evento.FechaHora, evento.Tipo, evento.Capacidad);
            }
            else
            {
                _crud.Modificar(evento.Id, evento.Nombre, evento.Lugar, evento.FechaHora, evento.Tipo, evento.Capacidad);
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

    #region Login Negocios

    //-------LOGIN SECCTION -------

    public class  UserModel
    {
        private UserKey userE = new UserKey();


        public bool LoginUser(string user, string password)

        {   //Si el usuario o la contraseña son nulos o vacíos, lanzamos una excepción          
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                return false; 
            }
            //Llama al metodo de la capa de datos para autenticar al usuario y llenar la cache
            return userE.Login(user, password);
        }

       
    }
    #endregion
}

