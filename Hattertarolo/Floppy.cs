using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{
    internal class Floppy : Hattertarol
    {
        private bool irasvedett;

        public Floppy(bool irasvedett) : base(1440000)
        {
            this.irasvedett = irasvedett;
        }
        public void irasVedett()
        {
            this.irasvedett = !this.irasvedett;
        }
        public override bool Format()
        {
            if (!irasvedett) { base.Format(); return true; }
            else { Console.WriteLine("nem sikerült a formázás"); return false; }
        }
        public override bool Hozzaad(string nev, string kiterjesztes, string tartalom)
        {
            if (!irasvedett) { base.Hozzaad(nev, kiterjesztes, tartalom); return true; }
            else { Console.WriteLine("nem sikerult a hozzaadas"); return false; }
        }
        public override bool Torol(string filenev)
        {
            if (!irasvedett) { base.Torol(filenev); return true; }
            else { Console.WriteLine("nem sikerult a torles"); return false; }
        }
    }
}
