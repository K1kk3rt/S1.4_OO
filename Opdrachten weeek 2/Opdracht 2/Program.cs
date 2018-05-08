using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        public void Main(string[] args)
        {
            Boekhandel boekhandel = new Boekhandel();
            Boek boek = new Boek();

            //Maak boeken
            Boek b1 = new Boek("November 9", 19.95, 10);
            Boek b2 = new Boek("It Ends With Us", 19.95, 2);
            Boek b3 = new Boek("Hopeless", 14.95, 5);
            Boek b4 = new Boek("Slammed", 12.95, 12);

            //voeg boeken toe aan list
            boekhandel.bladen.Add(b1);
            boekhandel.bladen.Add(b2);
            boekhandel.bladen.Add(b3);
            boekhandel.bladen.Add(b4);

            boek.Print(boekhandel);
        }
    }
}