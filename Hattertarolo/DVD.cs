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

        public DVD(int maxtaroloKapacitas):base(maxtaroloKapacitas)
        {
            this.maxtaroloKapacitas = 470000;
        }

        public void Zarolas()
        {
            this.zarolt = true;

        }



    }
}
