using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Perro: Mascota, IAdoptable   
    {

        public Perro() 
        {
            especie = "P";
        }

        public string AptoAdopcion()
        {
            if (NivelEnergia < 20)
                return "No se puede adoptar";
            else
                return "Es adoptable";

        }

        public override string HacerSonido()
        {
            return "Guau guau ...";
        }

        public override string Jugar()
        {
            if (NivelEnergia > 9)
            {
                if (Juguete.Uso > 1)
                {
                    NivelEnergia -= 10;
                    Juguete.Uso -= 25;
                    return "Jugando...";
                }
                else
                    return Juguete.Estado;
            }
            else
                return "No te queda energia";
       
        
        }
    }
}
