using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Hozz létre 7 elemű tömböt, adj hozzá 7 db tantárgyat,
      írd ki, hogy van-e benne Kémia tantárgy, 
      ha nincs írd ki, hogy nem található a tömben,
      ha van akkor írd ki, hogy van benne kémia tantárgy. 
      Írd ki egymás mellé, milyen tantárgyak vannak a tömben.*/
            string[] tantargyak = { "Informatika", "Matematika", "Testnevelés", "Fizika", "Ének-zene", "Földrajz", "Biológia" };
            if (tantargyak.Contains("Kémia"))
            {
                Console.WriteLine("Benne van a tömbben a Kémia tantárgy.");
            }
            else
            {
                Console.WriteLine("Nincs a tömben a Kémia tantárgy.");
            }

            Console.WriteLine(string.Join(",", tantargyak));



            string[] ujtantargyak = new string[7];
            for (int i = 0; i < tantargyak.Length; i++)
            {
                Console.WriteLine("Adj meg egy tantárgyat: ");
                string targy = Console.ReadLine();
                tantargyak[i] = targy;

            }
            if (tantargyak.Contains("Kémia"))
            {
                Console.WriteLine("Benne van a tömben a Kémia tantárgy.");
            }
            else
            {
                Console.WriteLine("Nincs a tömben a Kémia tantárgy.");
            }

            Console.WriteLine(string.Join(",", tantargyak));
        }
    }
}
