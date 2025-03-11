using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class LoL
    {

        
            public int Id;
            public string Rank;
            public int Meccsek;
            public int Veresegek;
            public string Karakterek;
            public string Osveny;
            public string Summonernev;

            public LoL( string Rank, string Meccsek, string Veresegek, string Karakterek, string Osveny, string Summonernev)
            {
                
                this.Rank = Rank;
                this.Meccsek = int.Parse(Meccsek);
                this.Veresegek = int.Parse(Veresegek);
                this.Karakterek = Karakterek;
                this.Osveny = Osveny;
                this.Summonernev = Summonernev;
            }
        
    }
}

