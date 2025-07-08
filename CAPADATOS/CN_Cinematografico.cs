using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DE_NEGOCIOS
{
    public class Cinematografico : EventoBase
    {
        //TODO Requisito: constructor implementado (en cada herencia)
        public Cinematografico()
        {
            Categoria = "Cinematografico";
        }

        //TODO Requisito: Implementacion del metodo abstracto
        public override string MiPatrocinadorFav()
        {
            return "Fundación Carlos Slim";
        }
    }
}
