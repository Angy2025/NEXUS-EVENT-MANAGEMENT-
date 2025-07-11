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
             Categoria = "Deportivo";
        }

        public override string ObtenerLema()
        {
            return "¡La competencia nos une, la victoria nos inspira!";
        }

        // Implementación del método abstracto obligatorio
        public override string MiPatrocinadorFav()
        {
            return "Gatorade"; 
        }
    }
    
}
