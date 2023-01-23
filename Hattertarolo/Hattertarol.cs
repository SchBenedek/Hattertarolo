using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{

    internal class Hattertarol
    {

        protected long maxtaroloKapacitas;
        protected List<Fajl> adatok = new List<Fajl>();
        public Hattertarol(int maxtaroloKapacitas)
        {
            this.MaxtaroloKapacitas = maxtaroloKapacitas;
            this.adatok = adatok;
        }


        protected long MaxtaroloKapacitas { get => maxtaroloKapacitas; set => maxtaroloKapacitas = value; }

        public override string ToString()
        {
            string output = "";
            foreach(var item in adatok)
            {
                output += item.ToString();
            }
            Console.WriteLine("niefnfug");
            return base.ToString() + $" {output}, {this.MaxtaroloKapacitas}";

        }

        public virtual bool Format()
        {
            this.adatok.Clear();
            return true;
        }

        public long MaxKapacitas()
        {
            return this.MaxtaroloKapacitas;
        }


        public virtual long SzabadKapacitas()
        {
            return MaxtaroloKapacitas - FoglaltKapacitas();
        }

        public int FoglaltKapacitas()
        {
            int foglaltkapacitas = 0;
            foreach(var file in adatok)
            {
                foglaltkapacitas += file.Tartalom.Count();
            }
            return foglaltkapacitas;
        }

        public virtual bool Hozzaad(string nev, string kiterjesztes, string tartalom)
        {
           if (Keres(nev) == null && SzabadKapacitas() > tartalom.Length)
            {
                this.adatok.Add(new Fajl(nev, kiterjesztes, tartalom));
                return true;
            }
           return false;
        }

        public Fajl Keres(string fajlnev)
        {
            foreach(var item in this.adatok)
            {
                if(item.Nev == fajlnev) 
                {
                    return item;
                }
            }
            return null;
        }
        
        public virtual bool Torol(string filenev)
        {
            Fajl cuc = Keres(filenev);
            adatok.Remove(cuc);
            return adatok.Remove(cuc);
        }

        public string Listaz(string kiterjeszetes)
        {
            string output = "";
            foreach (var item in this.adatok)
            {
                if (item.Kiterj == kiterjeszetes)
                {
                    output += $"{item.ToString()}\n";
                }
            }
            return output;
        }
    }
}
