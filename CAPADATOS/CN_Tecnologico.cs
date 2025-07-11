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
        // Sobrescribimos el método para los eventos de tecnología.
        public override string ObtenerLema()
        {
            return "Innovando hoy, construyendo el mañana.";
        }

        // Implementación del método abstracto.
        public override string MiPatrocinadorFav()
        {
            return "Nexus Tech"; 
        }
    }
}
