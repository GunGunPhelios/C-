using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozatgyakorláshatvány
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 1;
            for (int i = 0; i < 32; i++)
            {
            szam=szam*2;
                Console.WriteLine(szam);
            }
            
            Console.ReadKey();
        }
    }
}
