using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_CAPAS
{
    public class Profesional : EventoBase
    {
        public Profesional()
        {
            Tipo = "Profesional";
        }

        public override string MiPatrocinadorFav()
        {
            return "Fundación Carlos Slim";
        }
    }
}
