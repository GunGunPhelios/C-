using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        private static int rendeles;

        static void Main(string[] args)
        {
            List<Reklam> reklamok = new List<Reklam>();
            string[] sorok = File.ReadAllLines("rendel.txt");
            foreach (var item in sorok)
            {
                string[] adatok =item.Split(' ');
                Reklam uj= new Reklam(adatok[0], adatok[1], adatok[2]);
                reklamok.Add(uj);
               

            }
            Console.WriteLine("Kérem adjon meg egy napot: ");
            int megadottnap= int.Parse(Console.ReadLine());
            int rendelesekszama = 0;
            foreach(var item in reklamok)
            {
                if(item.rendelesnap== megadottnap)
                {
                    rendelesekszama++;
                   
                }
                //Console.WriteLine($"{item.rendelesnap}, {item.varos}, {item.rendeltdb}");
            }
            Console.WriteLine("2.feladat: ");
            Console.WriteLine($"A rendelések száma: {reklamok.Count}");
            Console.WriteLine("3. feladat: ");
            Console.WriteLine($"A rendelések száma az adott napon: {rendelesekszama}");
            Console.ReadKey();
        }
    }
}
