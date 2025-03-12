using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Gato: Mascota
    {
        public Gato() 
        {
            especie = "G";
        }
        public override string HacerSonido()
        {
            return "Miau Miauu...";
        }


    }
}
