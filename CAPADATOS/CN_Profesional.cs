using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class Profesional : EventoBase
    {
        public Profesional()
        {
            Tipo = "Profesional";
        }

        public override string ObtenerDetalles()
        {
            string resumenBase = base.ObtenerResumenEvento();

            return $"{resumenBase} Este evento Profesional se llevara a cabo el {ObtenerFechaBien()} y tendra una capacidad de {Capacidad} personas.;\r\n";
        }
    }
}
