using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static string connection = "server=localhost;database=regisztráció;user=root,password=;";
        static void Main(string[] args)
        {
            List<regisztráció> felhasználók = new List<regisztráció>();
            string[] sorok = File.ReadAllLines("register.txt");
            foreach (string sor in sorok)
            {
                string[] adatok =sor.Split(';');
                regisztráció ujfelhasznalo = new regisztráció(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                felhasználók.Add(ujfelhasznalo);


                
            }
            foreach (var felh in felhasználók)
            {
                Console.WriteLine($"{felh.nev},{felh.felnev}, {felh.email}, {felh.jelszo}, {felh.szuldatum}");
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    Console.WriteLine("Az adatbázis kapcsolat sikeresen létrejött!");
                }
                catch(Exception ex)
            {
                Console.WriteLine("Hiba történt a kapcsolódás során" + ex.Message );
            }
            
            Console.ReadKey();
        }

    }
        static void FelhasznaloHozzaad(string nev, string felnev, string email, string jelszo, DateTime szuldatum)
        {

        }
    }
}
