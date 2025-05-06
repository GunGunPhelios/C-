using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0506_Csomagoló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a dinnye átmérőjét (cm)");
            int atmero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a dinnyék számát");
            int dinnyedb = Convert.ToInt32(Console.ReadLine());

            double egydinnye = 2 * Math.PI*atmero + 60;
            double szuksegesSzalag = (egydinnye * dinnyedb) / 100;

            Console.WriteLine($"{dinnyedb} db dinnyéhez {Math.Round(szuksegesSzalag,2)} m szalag kell.");


            
            Console.ReadKey();

        }
    }
}
