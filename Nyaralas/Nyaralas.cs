using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyaralas
{
    internal class Nyaralas
    {
        public int sorszam;
        public string nev;
        public string szallas;
        public int foglalokszama;
        public int napokszama;
        public int ar;
        public string kedvezmeny;

        public Nyaralas(int sorszam, string nev, string szallas, int foglalokszama, int napokszama, int ar, string kedvezmeny)
        {
            this.sorszam = int.Parse(sorszam);
            this.nev = nev;
            this.szallas = szallas;
            this.foglalokszama =int.Parse(foglalokszama);
            this.napokszama = int.Parse(napokszama);
            this.ar = int.Parse(ar);
            this.kedvezmeny = kedvezmeny;
        }
    }
  
}
