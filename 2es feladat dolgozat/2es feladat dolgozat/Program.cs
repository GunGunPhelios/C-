using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2es_feladat_dolgozat
{
    internal class Program
    {
        static void Main()
        {
            string[] nevek = { "The Witcher 3: Wild Hunt", "Minecraft", "Cyberpunk 2077",
                           "Among Us", "The Elder Scrolls V: Skyrim", "Valorant" };

            Console.WriteLine("Eredeti lista: "+ String.Join(",", nevek) );
            for (int i = 0; i < nevek.Length; i++ ) 
            { 
                if (nevek[i].Equals("Valorant", StringComparison.OrdinalIgnoreCase)) 
                {
                    nevek[i] = "Fortnite";
                    break;

                }
            }
            Console.WriteLine("Módosított lista:"+ string.Join(",", nevek));
            Console.ReadKey();

        }
    }
}
