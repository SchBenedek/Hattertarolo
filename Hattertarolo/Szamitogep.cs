using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{
    internal class Szamitogep
    {
        private List<Hattertarol> hattertarolok = new List<Hattertarol>();

        public bool Felcsatol(Hattertarol felcsatolando)
        {
            hattertarolok.Add(felcsatolando);
            return true;
        }
        public long Osszkapcitas()
        {
            long osszeg = 0;
            foreach(var item in hattertarolok)
            {
                osszeg+=item.MaxKapacitas();
            }
            return Convert.ToInt32(osszeg);
        }

        public long SzabadKapacitas()
        {
            long szabadkapacitas = 0;
            foreach(var i in hattertarolok)
            {
                szabadkapacitas += i.SzabadKapacitas();
            }
            return szabadkapacitas;
        }
        public long Fogalaltkapcitas()
        {
            long osszeg = 0;
            foreach (var item in hattertarolok)
            {
                osszeg += item.FoglaltKapacitas();
            }
            return Convert.ToInt32(osszeg);
        }
        public bool Archival(string filenev)
        {
            foreach(var item in hattertarolok)
            {
                if(item.Keres(filenev) != null)
                {
                    Fajl file = item.Keres(filenev);
                    foreach (var i in hattertarolok)
                    {
                        if(i.Hozzaad(file.Nev, file.Kiterj, file.Tartalom) != null)
                        {
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
            return false; 
        }
    }
}
