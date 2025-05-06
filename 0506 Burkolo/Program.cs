using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0506_Burkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bemeneti adatok bekérése
            Console.Write("Add meg a burkolandó felület szélességét (méterben): ");
            double szelesseg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a burkolandó felület magasságát (méterben): ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            // Felület kiszámítása négyzetméterben
            double terulet = szelesseg * magassag;

            // Egy csempe területe négyzetméterben (20 cm x 20 cm = 0.2 m x 0.2 m)
            double egyCsempeTerulet = 0.2 * 0.2;

            // Szükséges csempék száma, ráhagyással
            double nyersDarabszam = terulet / egyCsempeTerulet;
            double teljesDarabszam = Math.Ceiling(nyersDarabszam * 1.1); // +10%, felfelé kerekítve

            // Eredmény kiírása
            Console.WriteLine($"\nA megadott {terulet:F2} m² felülethez {teljesDarabszam} db csempe szükséges.");
            Console.ReadKey();
        }
    }
}

