using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2es_feladat
{
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
