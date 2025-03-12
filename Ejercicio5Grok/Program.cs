using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Grok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota> mascotas = new List<Mascota>();

            int c = 0;
            string animal;
            while (true)
            {
                //Mascotas: Nombre y Edad
                Console.WriteLine("Es un Perro(a) o un Gato (b): ");
                animal = Console.ReadLine();
                Console.WriteLine("Escribe el nombre de la mascota: ");
                string name = Console.ReadLine();
                if (name == "stop")
                    break;
                Console.WriteLine("La edad: ");
                int edad = int.Parse(Console.ReadLine());
                //Se crea el objeto de la nueva mascota + sus propiedades
                Console.WriteLine("Nombre de su Juguete: ");
                string toy = Console.ReadLine();
                if (animal == "a")
                {
                mascotas.Add(new Perro());
                mascotas[c].Nombre = name;
                mascotas[c].Edad = edad;
                mascotas[c].Juguete.Nombre = toy;
                }
                else
                {
                    mascotas.Add(new Gato());
                    mascotas[c].Nombre = name;
                    mascotas[c].Edad = edad;
                    mascotas[c].Juguete.Nombre = toy;

                }

                c++;
               
            }

            while (true)
            {
                Console.WriteLine("El nombre de la mascota que buscas: ");
                string NombreBuscador = Console.ReadLine();
                Mascota MascotaActual = new Mascota();
                Perro P1 = new Perro();
                
                foreach (var mascota in mascotas)
                {
                    if (mascota.Nombre == NombreBuscador)
                        if (mascota.Especie == "P")
                        {

                            P1 = (Perro)mascota;
                            

                        }
                }
                if (MascotaActual.Nombre != NombreBuscador)
                    Console.WriteLine("No se encontro vuelve a buscar");
                else if (NombreBuscador == "stop")
                    break;
                else
                {
                    //Describimos a la mascota
                    Console.WriteLine($"La edad de {MascotaActual.Nombre} es: {MascotaActual.Edad}");
                    Console.WriteLine($"Su juguete esta: {MascotaActual.Juguete.Estado}");
                    //Jugamos...
                    Console.WriteLine("Desea Jugar?");
                    string jugar = Console.ReadLine();
                    while (jugar == "si")
                    {
                        MascotaActual.HacerSonido();
                        MascotaActual.Jugar();
                        Console.WriteLine($"El estado del jueguete es: {MascotaActual.Juguete.Estado}");

                        Console.WriteLine("Desea Jugar?");
                        jugar = Console.ReadLine();
                       
                        if (MascotaActual.Juguete.Estado == "Roto" || MascotaActual.Energia == "Muy Cansado")
                        {
                            Console.WriteLine("Jueguete roto o mascota muy cansada");
                            break;
                            
                        }    

                    }







                }

                
            }


        }
    }
}
