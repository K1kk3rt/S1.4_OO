using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersoonStruct p1 = new PersoonStruct("Simon", 40);
            PersoonClass p2 = new PersoonClass("Chris", 50);
            Console.WriteLine("struct persoon: " + p1.naam + ", " + p1.leeftijd);
            Console.WriteLine("class persoon: " + p2.naam + ", " + p2.leeftijd);
            Console.WriteLine();
            WijzigLeeftijd(p1);
            WijzigLeeftijd(p2);
            Console.WriteLine("struct persoon: " + p1.naam + ", " + p1.leeftijd);
            Console.WriteLine("class persoon: " + p2.naam + ", " + p2.leeftijd);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void WijzigLeeftijd(PersoonStruct p)
        {
            //Verschil struct vs class


            p.leeftijd++;
        }
        static void WijzigLeeftijd(PersoonClass p)
        {
            p.leeftijd++;
        }
    }
}
