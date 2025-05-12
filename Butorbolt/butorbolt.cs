using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorbolt
{
    internal class butorbolt
    {
        public string kategoria;
        public string termeknev;
        public int ar;
        public int raktar_db;
        public int eladott_db;

        public butorbolt(string kategoria, string termeknev, string ar, string raktar_db, string eladott_db)
        {
            this.kategoria = kategoria;
            this.termeknev = termeknev;
            this.ar = int.Parse(ar);
            this.raktar_db = int.Parse(raktar_db);
            this.eladott_db = int.Parse(eladott_db);
        }
    }
}
