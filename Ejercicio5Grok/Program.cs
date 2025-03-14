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
            //Start
            while (true)
            {
                //Mascotas: Nombre, Edad y juguete
                Console.WriteLine("Es un Perro(a) o un Gato (b) / Salir(stop): ");
                animal = Console.ReadLine();
                if (animal == "stop")
                    break;
                Console.WriteLine("Escribe el nombre de la mascota: ");
                string name = Console.ReadLine();

                Console.WriteLine("La edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre de su Juguete: ");
                string toy = Console.ReadLine();
                //Se crea el objeto de la nueva mascota + sus propiedades
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

            //BUSCANDO, CONOCIENDO Y JUGANDO
            while (true)
            {
                //Busqueda de la mascota
                Console.WriteLine("El nombre de la mascota que buscas: ");
                string NombreBuscador = Console.ReadLine();
                if (NombreBuscador == "stop")
                    break;

                Perro P1;
                Gato G1;
                bool found = false;
                foreach (var mascota in mascotas)
                {
                    if (mascota.Nombre == NombreBuscador)
                    {
                        //Mascota Encontrada
                        found = true;
                        //Caso PERRO
                        if (mascota.Especie == "P")
                        {
                            P1 = (Perro)mascota;



                            //Describimos a la mascota
                            Console.WriteLine($"La edad de {P1.Nombre} es: {P1.Edad}");
                            Console.WriteLine($"Su juguete esta: {P1.Juguete.Estado}");
                            //Jugamos...
                            Console.WriteLine("Desea Jugar?");
                            string jugar = Console.ReadLine();
                            while (jugar == "si")
                            {
                                //Jugando con juguete...
                                P1.HacerSonido();
                                P1.Jugar();
                                Console.WriteLine($"El estado del jueguete es: {P1.Juguete.Estado}");
                                //Repeticion de accion
                                Console.WriteLine("Desea Jugar?");
                                jugar = Console.ReadLine();

                                if (P1.Juguete.Estado == "Roto" || P1.Energia == "Muy Cansado")
                                {
                                    //Rompe ciclo de juego
                                    Console.WriteLine("Jueguete roto o mascota muy cansada");
                                    break;

                                }
                            }
                            P1.AptoAdopcion();
                        }
                        //Caso GATO
                        else if (mascota.Especie == "G")
                        {
                            G1 = (Gato)mascota;


                            //Describimos a la mascota
                            Console.WriteLine($"La edad de {G1.Nombre} es: {G1.Edad}");
                            Console.WriteLine($"Su juguete esta: {G1.Juguete.Estado}");
                            //Jugamos...
                            Console.WriteLine("Desea Jugar?");
                            string jugar = Console.ReadLine();
                            while (jugar == "si")
                            {
                                //Jugando con juguete...
                                G1.HacerSonido();
                                G1.Jugar();
                                Console.WriteLine($"El estado del jueguete es: {G1.Juguete.Estado}");
                                //Repeticion de accion
                                Console.WriteLine("Desea Jugar?");
                                jugar = Console.ReadLine();

                                if (G1.Juguete.Estado == "Roto" || G1.Energia == "Muy Cansado")
                                {
                                    //Rompe ciclo de juego
                                    Console.WriteLine("Jueguete roto o mascota muy cansada");
                                    break;

                                }
                            }
                            G1.AptoAdopcion();

                        }
                    }


                    
                }
                if (!found)
                    Console.WriteLine("No se encontro la mascota");


            }
            Console.ReadKey();
        }
    }
}

               
                    