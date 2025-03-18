using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class ellenorzes
    {
        public static string connect = "server=localhost;database=bank;user=root;password=;";
        public static AdatEllenorzes(string tulajdonos_nev, int azonosito, int pinkod)
        {
            string query= "SELECT tulajdonos_nev, azonosito,pinkot FROM szamla_tulajdonosok WHERE tulajdonos_nev"
        using (MySqlConnection conn= new MySqlConnection(connect))
            {
                conn.Open();
                using(MySqlCommand cmd= new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tulajdonos_nev", tulajdonos_nev);
                    cmd.Parameters.AddWithValue("@azonosito", azonosito);
                    cmd.Parameters.AddWithValue("@pinkod", pinkod);
                    cmd.ExecuteNonQuery();
                }
                using(MySqlDataReader reader= new MySqlDataReader(cmd,conn))
                {
                    reader.Read();
                    sikeres=true;

                }
            }
                }
        return sikeres;
internal static bool AdatEllenorzes(string tulajdonos_neve, int azonositas, int pinkodmegad)
        {
            throw new NotImplementedException();
        }
    }
}
