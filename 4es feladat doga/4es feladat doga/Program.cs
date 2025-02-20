using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4es_feladat_doga
{
    internal class Program
    {
        static void Main()
        {
            List<int> paros = new List<int>();
            Console.WriteLine("Adj meg öt számot!");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" {i + 1}. szám");
                if (int.TryParse(Console.ReadLine(), out int szam))
                {
                    if (szam % 2 == 0)
                    {
                        paros.Add(szam);
                        Console.WriteLine($"✅ A(z) {szam} páros, és hozzáadva a listához ({paros.Count}. elemként)");
                    }
                    else
                    {
                        Console.WriteLine($"❌ A(z) {szam} páratlan, ezért nem kerül a listába.");
                    }
                }
                else
                {
                    Console.WriteLine("Érvénytelen bemenet, próbáld újra!");
                    i--;



                }
            }


                Console.WriteLine($"\n📋 A páros számok listájában {paros.Count} elem van.");
                Console.WriteLine("Lista tartalma: " + (paros.Count > 0 ? string.Join(", ", paros) : "Nincs páros szám a listában."));


            
        }
    }
}
