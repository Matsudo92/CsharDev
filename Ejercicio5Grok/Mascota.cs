using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Mascota
    {
        public Mascota()
        {
            NivelEnergia = 100;
            Juguete = new Juguete();
        }

        protected string especie { get; set; }

        public string Especie
        {
            get { return especie; }
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        protected int NivelEnergia { get; set; }
        public string Energia
        {
            get {
                if (NivelEnergia == 0)
                    return "Muy Cansado";
                else
                    return "Energetico";
                }
        }

        public Juguete Juguete { get; set; }

        public virtual string Jugar()
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

        public virtual string HacerSonido()
        {
            return "Haciendo sonido";
        }

        public void NewToy()
        {
            Juguete.Uso = 100;
        }


    }

}
