using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{
    internal class DVD: Hattertarol

    {
        protected bool zarolt = false;

        public DVD():base(470000000)
        {
            this.zarolt = zarolt;
        }

        public void Zarolas()
        {
            this.zarolt = true;
        }
        public override long SzabadKapacitas()
        {
            if (zarolt) { return 0; }
            else { return base.SzabadKapacitas(); }
           
        }
        public override bool Format()
        {
            if (!zarolt)
            {
                base.Format(); return true;
            }
            else
            {
                Console.WriteLine("nem sikerült a formázás"); return false; 
            }
        }
        public override bool Hozzaad(string nev, string kiterjesztes, string tartalom)
        {
            if (!zarolt)
            {
                base.Hozzaad(nev, kiterjesztes, tartalom); return true; 
            }
            else
            {
                Console.WriteLine("nem sikerult a hozzaadas"); return false;
            }
        }
        public override bool Torol(string filenev)
        {
            if (!zarolt)
            {
                base.Torol(filenev); return true;
            }
            else 
            {
                Console.WriteLine("nem sikerult a torles"); return false;
            }
        }
        



    }
}
