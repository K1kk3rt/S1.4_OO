using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenA
{
    class Programmeur
    {
        public string naam;
        public Specialiteit specialiteit;

        //Geef een naam en Specialiteit mee wanneer object wordt aangemaakt (Constructor)
        public Programmeur(string n, Specialiteit s)
        {
            this.naam = n;
            this.specialiteit = s;
        }

        //Print meegegeven programmeur vanuit class Team
        public void Print(Programmeur programmeur)
        {
            Console.WriteLine("Naam: {0}\n Specialiteit: {1}", programmeur.naam, programmeur.specialiteit);
        }
    }
}
