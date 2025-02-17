
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozatgyakorlat

/*
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();



            List<int> paratlan = new List<int>();
            while (paratlan.Count < 32) {

                int szam = rnd.Next(1, 50);
                if (szam % 2 == 0)
                {
                    Console.WriteLine($"A szám páros {szam}.");
                }
                else
                {
                    Console.WriteLine($"A szám páratlan {szam}.");
                    paratlan.Add(szam);

                }
                }
            Console.WriteLine(string.Join(",", paratlan));
            Console.WriteLine($"A lista hossza: {paratlan.Count}");
            Console.ReadKey();
        }
           

        }
    }

        Console.ReadKey();
*/

/* 2es feladat */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> szamok = new List<int>();
        int szamokSzama = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Kérlek, adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            szam += 2;
            if (szam > 20 && szam < 100)
            {
                szamok.Add(szam);
                szamokSzama++;
                Console.WriteLine($"{szamokSzama}. szám hozzáadva: {szam}");
            }
        }

        Console.WriteLine($"A lista hossza: {szamokSzama}");
    }
}





}