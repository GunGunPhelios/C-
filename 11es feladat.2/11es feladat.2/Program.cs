using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11es_feladat._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

         
                    Console.WriteLine("Adj meg egy pozitív egész számot!");
                    int bekertszam = int.Parse(Console.ReadLine());
                    int oszto = 2;
                    while (bekertszam > 1)
                    {
                        if (bekertszam % oszto == 0)
                        {
                            Console.WriteLine($"{bekertszam} / {oszto}");
                            bekertszam /= oszto;

                        }
                        else
                        {
                            oszto++;
                        }
                    }

                }
            }
        }
}

