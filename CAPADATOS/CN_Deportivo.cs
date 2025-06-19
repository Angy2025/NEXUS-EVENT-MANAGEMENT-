using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class Deportivo : EventoBase
    {
        public Deportivo()
        {
             Tipo = "Deportivo";
        }

        public override string ObtenerDetalles()
        {
            string resumenBase = base.ObtenerResumenEvento();

                return $"{resumenBase} Este evento deportivo se llevara a cabo el {ObtenerFechaBien()} y tendra una capacidad de {Capacidad} personas.;\r\n";
        }
    }
    
}
