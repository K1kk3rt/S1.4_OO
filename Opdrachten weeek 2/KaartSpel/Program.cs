using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            KaartSpel spel = new KaartSpel(2);
            spel.Print();
            Console.ReadKey();
        }
    }
}
