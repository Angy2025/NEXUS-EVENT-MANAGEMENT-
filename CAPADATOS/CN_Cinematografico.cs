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

        //TODO Sobrescribimos el método para los eventos de cine
        public override string ObtenerLema()
        {
            return "Luces, cámara, ¡acción y emoción!";
        }

        //TODO Implementación del método abstracto
        public override string MiPatrocinadorFav()
        {
            return "Caribbean Cinemas y Fundacion de Carlos Slim";
        }
    }
}
