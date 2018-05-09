using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Boekhandel
    {
        public List<Boek> bladen = new List<Boek>();

        public void PrintVoorraad()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}, {1}, {2}", "Titel", "Prijs", "Voorraad");

            foreach (Boek item in bladen)
            {
                item.Print();
            }
            Console.ResetColor();
        }

        public void VoegToe(Boek boek)
        {
            bladen.Add(boek);
        }
    }
}
