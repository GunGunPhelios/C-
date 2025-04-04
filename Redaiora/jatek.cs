using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redaiora
{
    internal class jatek
    {
        public string Termek { get; set; }
        public string Kategoria { get; set; }

        public int Ar { get; set; }

        public int Keszlet { get; set; }


        public jatek(string termek, string kategoria, int ar, int keszlet)
        {
            Termek = termek;
            Kategoria = kategoria;
            Ar = ar;
            Keszlet = keszlet;
        }

        public jatek()
        {
        }

        public override string ToString()
        {
            return $"{Termek} {Kategoria} {Ar} {Keszlet}";

        }
    }
}
