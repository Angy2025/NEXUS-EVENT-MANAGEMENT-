using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class ObtencionDatosEstatus
    {
            // Este manager usa el CN_EventosManager principal para obtener la lista completa de eventos.
            private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

            // Estos métodos provienen del FormularioEstatus
            //La responsabilidad de este es obtener solo los eventos activos para la primera pestaña
            public List<EventoBase> ObtenerEventosActivos()
            {
                var todosLosEventos = _eventosManager.ObtainAllEvents();
                return todosLosEventos
                    .Where(e => e.Estatus == "Planificado" || e.Estatus == "Confirmado")
                    .OrderBy(e => e.FechaHora)
                    .ToList();
            }

            // Su responsabilidad es obtener solo el historial para la segunda pestaña
            public List<EventoBase> ObtenerEventosDeHistorial()
            {
                var todosLosEventos = _eventosManager.ObtainAllEvents();
                return todosLosEventos
                    .Where(e => e.Estatus == "Realizado" || e.Estatus == "Cancelado")
                    .OrderByDescending(e => e.FechaHora)
                    .ToList();
            }

            // Se usa para obtener todos los detalles de un evento para generar el reporte
            public EventoBase? ObtenerEventoPorId(int id)
            {
                var todosLosEventos = _eventosManager.ObtainAllEvents();
                return todosLosEventos.FirstOrDefault(e => e.Id == id);
            }
        }
    }





