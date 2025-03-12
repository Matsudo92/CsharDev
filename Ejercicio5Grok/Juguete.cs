using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Juguete
    {
        public Juguete() 
        {
            Uso = 100;
        }

        public string Nombre {  get; set; }
        public int Uso { get; set; }
        public string Estado
        {
            get 
            {
                if (Uso > 0)
                    return "Nuevo";

                else 
                  return "Roto"; 
            
            }
        }


    }
}
