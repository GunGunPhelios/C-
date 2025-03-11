using System;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "server=localhost;database=dolgozat;user=root;password=;"; 
        string filePath = "lol.txt"; // A fájl neve

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"❌ Hiba: A fájl nem található: {filePath}");
            Console.ReadKey();
            return;
        }

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("✅ Sikeresen csatlakoztál az adatbázishoz!");

                string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();
                int insertedCount = 0;

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';').Select(p => p.Trim()).ToArray();


                    if (parts.Length != 7)
                    {
                        Console.WriteLine($"⚠️ Hiba: Rossz formátum a következő sorban: {line}");
                        continue;
                    }

                    string Rank = parts[0].Trim();
                    if (!int.TryParse(parts[1], out int Meccsek))
                    {
                        Console.WriteLine($"⚠️ Hiba: Érvénytelen meccsek érték a következő sorban: {line}");
                        continue;
                    }

                    if (!int.TryParse(parts[2], out int Vereseg))
                    {
                        Console.WriteLine($"⚠️ Hiba: Érvénytelen vereségek érték a következő sorban: {line}");
                        continue;
                    }
                    Console.WriteLine($"🔍 Ellenőrzés: Meccsek='{parts[1]}', Vereseg='{parts[2]}'");
                    string Karakterek = parts[3].Trim();
                    string Osveny = parts[4].Trim();
                    string Summonernev = parts[5].Trim();

                    string query = @"INSERT INTO leagueplayers (Rank, Meccsek, Vereseg, Karakterek, Osveny, Summonernev) 
                                     VALUES (@Rank, @Meccsek, @Vereseg, @Karakterek, @Osveny, @Summonernev)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rank", Rank);
                        cmd.Parameters.AddWithValue("@meccsek", Meccsek);
                        cmd.Parameters.AddWithValue("@vereseg", Vereseg);
                        cmd.Parameters.AddWithValue("@karakterek", Karakterek);
                        cmd.Parameters.AddWithValue("@osveny", Osveny);
                        cmd.Parameters.AddWithValue("@summonernev", Summonernev);

                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"🔹 {rowsAffected} sor beszúrva: {Rank}, {Meccsek}, {Vereseg}, {Karakterek}, {Osveny}, {Summonernev}");
                        insertedCount++;
                    }
                }

                Console.WriteLine($"✅ {insertedCount} adat sikeresen feltöltve az adatbázisba!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hiba történt: {ex.Message}");
            }
        }

        Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
        Console.ReadKey();
    }
}
