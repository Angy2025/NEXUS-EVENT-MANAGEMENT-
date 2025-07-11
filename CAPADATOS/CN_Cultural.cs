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
            Categoria = "Cultural";
        }

        // Sobrescribimos el método para los eventos culturales
        public override string ObtenerLema()
        {
            return "Celebrando el arte que nos define.";
        }

        // Implementación del método abstracto
        public override string MiPatrocinadorFav()
        {
            return "Ministerio de Cultura"; 
        }
    }
}
