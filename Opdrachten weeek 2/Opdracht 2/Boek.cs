using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Boek
    {
        public string titel;
        public double prijs;
        public int voorraad;

        //Constructor
        public Boek(string titel, double prijs, int voorraad)
        {
            this.titel = titel;
            this.prijs = prijs;
            this.voorraad = voorraad;
        }

        //Default Constructor
        public Boek()
        {
            titel = "";
            prijs = 0;
            voorraad = 0;
        }

        public void Print(Boekhandel boekhandel)
        {
            for(int i = 0; i < boekhandel.bladen.Capacity; i++) 
            {
                Console.WriteLine("{0}, {1}, {2}", boekhandel.bladen);
            }
        }
    }
}
