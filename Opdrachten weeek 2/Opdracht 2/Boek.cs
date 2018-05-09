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

        //Methods
        public virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0}, {1}, {2}", titel, prijs, voorraad);
        }

        public void WijzigVoorraad(Boek boek, Boekhandel boekhandel)
        {
            bool boekgevonden = false;

            foreach (Boek item in boekhandel.bladen)
            {
                if (item.titel == boek.titel)
                {
                    item.voorraad = boek.voorraad;
                    boekgevonden = true;
                }
            }
            if (boekgevonden)
            {
                Console.WriteLine("De voorraad van {0} is gewijzigd naar {1}", boek.titel, boek.voorraad);
            }
            else
            {
                Console.WriteLine("Boek niet gevonden");
            }
        }
    }

    class Weekblad : Boek
    {
        //fields
        public string dagVanUitgifte;

        //Constructor
        public Weekblad (string titel, double prijs, int voorraad, string dagVanUitgifte) : base(titel, prijs, voorraad)
        {
            this.dagVanUitgifte = dagVanUitgifte;
        }

        //Default constructor
        public Weekblad()
        {
            titel = "";
            prijs = 0;
            voorraad = 0;
            dagVanUitgifte = "";
        }

        //Methods
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0}, {1}, {2}, {3}", titel, prijs, voorraad, dagVanUitgifte);
        }
    }
}
