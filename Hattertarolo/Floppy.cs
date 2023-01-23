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

        public Floppy(bool irasvedett) : base()
        {
            this.irasvedett = irasvedett;
            this.MaxtaroloKapacitas = 1440*1024;
        }

        public bool Irasvedett { get => irasvedett; set => irasvedett = value; }

        public new void Format()
        {
            if (irasvedett)
            {
                throw 
            }
            Format();
        } 
    }
}
