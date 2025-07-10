using System;
using System.Collections.Generic;
using System.Linq;


namespace CAPA_DE_NEGOCIOS
{
    public class EstadisticaGestion
    {
        // Este método proviene del FormularioGestion
        // Su responsabilidad es aplicar la regla de negocio para encontrar
        // el próximo evento futuro de una lista completa
        public EventoBase? ObtenerProximoEvento(List<EventoBase> todosLosEventos)
        {
            if (todosLosEventos == null || !todosLosEventos.Any())
            {
                return null;
            }

            var proximoEvento = todosLosEventos
                                    .Where(e => e.FechaHora >= DateTime.Now)
                                    .OrderBy(e => e.FechaHora)
                                    .FirstOrDefault();

            return proximoEvento;
        }
    }
}
