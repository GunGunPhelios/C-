using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL
{
    internal class LoL
    {
        public int Id;
        public string Rank;
        public int Meccsek;
        public int Veresegek;
        public string karakterek;
        public string osveny;
        public string Summonernev;

        public LoL(string Id, string Rank, string Meccsek, string Veresegek, string karakterek, string osveny, string Summonernev)
        {
            this.Id = int.Parse(Id);
            this.Rank = Rank;
            this.Meccsek = int.Parse(Meccsek);
            this.Veresegek = int.Parse(Veresegek);
            this.karakterek = karakterek;
            this.osveny = osveny;
            this.Summonernev = Summonernev;
        }
    }
}