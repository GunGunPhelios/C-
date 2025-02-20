using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendéglista_ViViÁgistb
{
    internal class Program
    {
        static void Main()
        {
            List<string> Vendeglista = new List<string>();
            const int maxVendegszam= 5;

            while(Vendeglista.Count< maxVendegszam)
            {
                Console.WriteLine("Kérem adja meg a meghívni kívánt vendég nevét!");
                string nev= Console.ReadLine();
            if (!string.IsNullOrEmpty(nev) )
                {
                    Vendeglista.Add(nev);

                }
            else
                {
                    Console.WriteLine("Nem adtál meg érvényes nevet!");

                }

            }
            while (true)
            {
                Console.WriteLine("\nHa szeretnél még valakit meghívni a felsoroltakon kívül, ki kell cserélned egy nevet!");
                Console.Write("Új vendég neve: ");
                string ujVendeg= Console.ReadLine();

                Console.Write("Kérlek írd be kit szeretnél lecseréni.");
                string torlendonev= Console.ReadLine();

                if (Vendeglista.Contains(torlendonev) )
                {
                    int index = Vendeglista.IndexOf(torlendonev);
                    Vendeglista[index] = torlendonev;
                }
                else
                {
                    Console.WriteLine("A megadott név nem szerepel a listán");
                    continue;
                }
                Vendeglista.Sort();
                Console.WriteLine($"\nFrissített, sorba rendezett vendéglista: {string.Join(", ", Vendeglista)}");
            }
            }
        }
    }

