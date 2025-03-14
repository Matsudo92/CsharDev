using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Gato: Mascota, IAdoptable
    {
        public Gato() 
        {
            especie = "G";
        }

        public string AptoAdopcion()
        {
            if (NivelEnergia < 30)
                return "No es adoptable";
            else
                return "Es Adoptable";
        }

        public override string HacerSonido()
        {
            return "Miau Miauu...";
        }


    }
}
