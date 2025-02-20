using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3as_feladat_dolgozat
{
    internal class Program
    {
        static void Main()
        {
            List<int> szamok = new List<int>();
            Console.WriteLine("Adj meg számokat! A bekérés 0-ig tart.");
            while (true)
            {
                Console.Write("Adj meg egy számot!");
                if (int.TryParse(Console.ReadLine(), out int szam))
                {
                    if (szam == 0) break;

                    szamok.Add(szam);
                }




                else
                {
                    Console.WriteLine("Érvénytelen bemenet, próáld újra!");
                }
            }
                if (szamok.Count == 0)
                {
                    szamok.Sort();
                    szamok.Reverse();
                    Console.WriteLine("\nRendezett lista (csökkenő sorrendben): " + string.Join(", ", szamok));
                    Console.WriteLine("A legnagyobb szám: " + szamok[0]);
                }
                else
                {
                    Console.WriteLine("Nem adtál meg egyetlen számot sem!");
                }
                
                    

            
        }
    }
}
