using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class Cultural : EventoBase
    {
        public Cultural()
        {
            Tipo = "Cultural";
        }

        public override string ObtenerDetalles()
        {
            string resumenBase = base.ObtenerResumenEvento();

            return $"{resumenBase} Este evento cultural se llevara a cabo el {ObtenerFechaBien()} y tendra una capacidad de {Capacidad} personas.;\r\n";
        }
    }
}
