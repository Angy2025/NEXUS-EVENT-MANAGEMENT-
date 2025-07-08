using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPA_DE_NEGOCIOS
{
    public class Tecnologico : EventoBase
    {
        public Tecnologico()
        {
            Categoria = "Tecnologico";
        }
        public override string MiPatrocinadorFav()
        {
            return "Fundación Carlos Slim";
        }
    }
}
