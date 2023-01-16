using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{
    internal class Fajl
    {
        private string nev;
        private string kiterj;
        private string tartalom;

        public Fajl(string nev, string kiterj, string tartalom)
        {
            this.nev = nev;
            this.kiterj = kiterj;
            this.tartalom = tartalom;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Kiterj { get => kiterj; set => kiterj = value; }
        public string Tartalom { get => tartalom; set => tartalom = value; }

        public override string ToString()
        {
            return $"{this.nev}, {this.kiterj}, {this.tartalom}";
        }
    }
}
