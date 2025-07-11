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
            Categoria = "Profesional";
        }

        // Sobrescribimos el método para los eventos profesionales.
        public override string ObtenerLema()
        {
            return "Conectando mentes, impulsando carreras.";
        }

        // Implementación del método abstracto.
        public override string MiPatrocinadorFav()
        {
            return "LinkedIn"; 
        }
    }
}
