using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class Update
    {
        public static string connection = "localhost=server;database=iskola;user=root;password=;";

        public static void AdatModosit(int diak id, string dveznev, string keresztnev, string osztaly)
        {
            string query= "UPDATE diak SET dveznev= @dveznev, dkeresztnev= @dkeresztnev, osztaly= @osztaly WHERE diak_id=@id "
        }   using (MysqlConnection cmd = new MysqlConnection(Query,conn)){
            cmd.Parameters.AddWithValue(@ID,ID);
            cmd.Parameters.AddWithValue(@dveznev, dveznev);
        cmd.Parameters.AddWithValue(@dkernev, dkernev);
        cmd.Parameters.AddWithValue(@dosztaly, dosztaly);
        cmd.Parameters.AddWithValue(@ID, ID);
        cmd.Parameters.AddWithValue(@ID, ID);


            }
}
