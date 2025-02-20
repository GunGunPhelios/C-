using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smurfök
{
    internal class Program
    {
        static void Main()
        {
            List<string> torpok = new List<string> { "Okoska", "Törpilla", "Szundi", "Törperős", "Ügyifogyi", "Hami" };

            // Véletlenszerű törp kiválasztása
            Random random = new Random();
            int index = random.Next(torpok.Count);
            string elraboltTorp = torpok[index];

            // Eredmény kiírása
            Console.WriteLine("Hókuszpók fogságba ejtett egy törpöt! Próbáld kitalálni, hogy kit!");
            Console.WriteLine("A faluban lévő törpök: " + string.Join(", ", torpok));

            while (true)
            {
                Console.Write("Írd be annak a törpnek a nevét, akit szerinted elrabolt: ");
                string tipp = Console.ReadLine();

                if (tipp.Equals(elraboltTorp, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Gratulálok! Kitaláltad, hogy Hókuszpók " + elraboltTorp + " törpöt ejtette fogságba!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sajnos nem talált, próbáld újra!");
                }
            }
        }
    }
}