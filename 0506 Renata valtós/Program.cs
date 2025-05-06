using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };
            Console.WriteLine("Adj meg egy összeget:");
            int osszeg = Convert.ToInt32(Console.ReadLine());
            while (osszeg > 0)
            {
                for (int i = 0; i < cimletek.Length; i++) {
                    int eredmeny = osszeg / cimletek[i];
                    if (eredmeny > 0) {
                        osszeg -= eredmeny * cimletek[i];
                        Console.WriteLine($"{eredmeny} db {cimletek[i]}");

                    }

                }
                Console.ReadKey();
            }
        }
    }
}


