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
            h1.Hozzaad("Html", "js", "10");
            h1.Hozzaad("Python", "html","feketezsemle,szemek,sziv, jumbotron doboz");
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h1.Listaz("oop"));


            Floppy f1 = new Floppy(true);
            f1.Hozzaad("rak", "txt", "Lorem Ipsum dolor sit amet");
            Console.WriteLine(f1.FoglaltKapacitas());
            Console.WriteLine(f1.Listaz("txt"));
            f1.Format();
            Console.WriteLine(f1.FoglaltKapacitas());



            Console.ReadLine();
        }
    }
}
