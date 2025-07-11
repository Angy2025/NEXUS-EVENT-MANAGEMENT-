using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class ConfingeventosDetalle
    {
        // Este método proviene del método ConfigurarComboBox del FormAgregar
        // Su responsabilidad es definir la lista oficial de categorías de eventos
        // Si en el futuro se agrega una nueva categoría, solo se cambia aquí
        public List<string> ObtenerCategoriasDisponibles()
        {
            return new List<string>
            {
                "Deportivo",
                "Cultural",
                "Tecnológico",
                "Cinematográfico",
                "Profesional"
            };
        }

        // Este método proviene del bloque 'switch' del botón Guardar en FormAgregar
        // Su responsabilidad es crear la instancia correcta del objeto Evento basado en su categoría


        public EventoBase CrearEventoPorTipo(string categoria)
        {
            switch (categoria)
            {
                case "Deportivo": return new Deportivo();
                case "Cultural": return new Cultural();
                case "Tecnológico": return new Tecnologico();
                case "Cinematográfico": return new Cinematografico();
                case "Profesional": return new Profesional();
                default:
                    // Si la categoría no es válida, se lanza un error para evitar crear un objeto incorrecto
                    throw new ArgumentException("La categoría del evento no es válida.", nameof(categoria));
            }
        }

    }
}
