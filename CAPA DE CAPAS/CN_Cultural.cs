using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPA_DE_CAPAS
{
    public class Cultural : EventoBase
    {
        public Cultural()
        {
            Tipo = "Cultural";
        }

        public override string MiPatrocinadorFav()
        {
            return "Fundación Carlos Slim";
        }
    }
}
