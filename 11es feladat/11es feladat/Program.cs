using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11es_feladat
{

    /*class Program
    {
        static void Main()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                Console.Write($"A {number} prímtényezős felbontása: ");
                List<int> primeFactors = GetPrimeFactors(number);
                Console.WriteLine(string.Join(" × ", primeFactors));
            }
            else
            {
                Console.WriteLine("Hibás bevitel! Pozitív egész számot adj meg.");
            }
            Console.ReadKey();
        }

        static List<int> GetPrimeFactors(int n)
        {
            List<int> factors = new List<int>();

            // Kettes osztók kiszűrése
            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }

            // Prím osztók keresése 3-tól kezdve
            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            // Ha n maga egy prím szám, és nagyobb mint 2, akkor hozzáadjuk
            if (n > 2)
            {
                factors.Add(n);
            }

            return factors;
            
        }
    }
}

    */
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int bekertszam = int.Parse(Console.ReadLine());
            int oszto = 2;
            while (bekertszam >1)
            {
                if (bekertszam% oszto == 0)
                {
                    Console.WriteLine($"{bekertszam} / {oszto}");
                    bekertszam /= oszto;

                }
                else
                {
                    oszto++;
                }
            }
            