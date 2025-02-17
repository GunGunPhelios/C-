using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3as_feladat
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] nevek = { "Anna", "Elemér", "Béla", "John", "Jenna", "Kinga" };

            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek[i] == "Anna")
                {
                    nevek[i] = "Kata";
                }
            }

            Console.WriteLine(string.Join(", ", nevek));
        }
    }
}


