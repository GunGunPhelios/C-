
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using LoL;

namespace LoL
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=lol;user=root;password=;";

        static void Main(string[] args)
        {
            List<LoL> jatekok = new List<LoL>();
            string[] sorok = File.ReadAllLines("lol.txt");
            foreach (var item in sorok)
            {
                string[] adatok = item.Split(',');
                LoL ujjatek = new LoL(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6]);
                jatekok.Add(ujjatek);
            }

            foreach (var item in jatekok)
            {
                Console.WriteLine($"{item.Id},{item.Rank},{item.Meccsek},{item.Veresegek},{item.karakterek},{item.osveny},{item.Summonernev}");
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    //UjFelhasznalo("Kiss Péter", "peter@example.com");
                    //UjFelhasznalo("Nagy Anna", "anna@example.com");
                    Console.WriteLine("Add meg az id-t");
                    int id= int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a rankot");
                    string rank=Console.ReadLine();
                    Console.WriteLine("Add meg a meccsek számát.");
                    int meccsek= int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a vereségek számát");
                    int veresegek = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kérlek add meg a karakter nevét");
                    string karakterek= Console.ReadLine();
                    Console.WriteLine("Add meg az ösvényt;");
                    string osveny= Console.ReadLine();
                    Console.WriteLine("Add meg a Summonernevet");
                    string Summonernev= Console.ReadLine();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }
            Console.ReadKey();
        }

        static void ujjatek(int Id, string Rank, int Meccsek, int Veresegek, string karakterek, string osveny, string Summonernev)
        {
            string query = "INSERT INTO interek (Id,Rank,Meccsek,Veresegek,karakterek,osveny, Summonernev) VALUES (@id, @rank,@meccsek,@veresegek,@karakterek,@osveny, @Summmonernev)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Rank", Rank);
                    cmd.Parameters.AddWithValue("@Meccsek", Meccsek);
                    cmd.Parameters.AddWithValue("@Veresegek", Veresegek);
                    cmd.Parameters.AddWithValue("@karakterek", karakterek);
                    cmd.Parameters.AddWithValue("@osveny", osveny);
                    cmd.Parameters.AddWithValue("@Summonernev", Summonernev);




                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}