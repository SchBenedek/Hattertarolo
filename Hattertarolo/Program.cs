using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattertarolo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hattertarol h1 = new Hattertarol(69696969);
            Console.WriteLine(h1);
            h1.Hozzaaad("kagsi", "oop", "verda animációk");
            h1.Hozzaaad("nigger", "oop","feketezsemle,szemek,sziv");

            Console.WriteLine(h1.Listaz("oop"));

            Console.ReadLine();
        }
    }
}
