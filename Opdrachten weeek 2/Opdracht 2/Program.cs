using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static Boekhandel boekhandel = new Boekhandel();
        static Boek boek = new Boek();
        static Weekblad weekblad = new Weekblad();

        static void Main(string[] args)
        {
            

            //Maak boeken
            Boek b1 = new Boek("November 9", 19.95, 10);
            Boek b2 = new Boek("It Ends With Us", 19.95, 2);
            Boek b3 = new Boek("Hopeless", 14.95, 5);
            Boek b4 = new Boek("Slammed", 12.95, 12);

            //Maak tijdschriften
            Weekblad w1 = new Weekblad("Quote", 4.95, 6, "9/5/2018");
            Weekblad w2 = new Weekblad("Pokemon", 2.95, 2, "9/5/2018");
            Weekblad w3 = new Weekblad("Autoweek", 6.95, 20, "9/5/2018");
            Weekblad w4 = new Weekblad("Topgear", 7.95, 25, "9/5/2018");

            //voeg boeken en tijdschriften toe aan list
            boekhandel.bladen.Add(b1);
            boekhandel.bladen.Add(b2);
            boekhandel.bladen.Add(b3);
            boekhandel.bladen.Add(b4);
            boekhandel.bladen.Add(w1);
            boekhandel.bladen.Add(w2);
            boekhandel.bladen.Add(w3);
            boekhandel.bladen.Add(w4);

            Menu();

            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("Menu:");
            while (true)
            {
                Console.WriteLine("1. Laat voorraad zien");
                Console.WriteLine("2. Wijzig voorraad");
                Console.WriteLine("3. Voeg boek of tijdschrift toe");

                string input = Console.ReadLine();
                int keuze;
                if (!Int32.TryParse(input, out keuze))
                {
                    Console.WriteLine("Geen getal, probeer opnieuw");
                }
                if (keuze > 3 || keuze < 0)
                {
                    Console.WriteLine("Ongeldige invoer, probeer opnieuw");
                }

                switch (keuze)
                {
                    case 1:
                        boekhandel.PrintVoorraad();
                        break;
                    case 2:
                        Console.WriteLine("Geef titel:");
                        boek.titel = Console.ReadLine();
                        Console.WriteLine("Nieuwe voorraad: ");
                        boek.voorraad = Int32.Parse(Console.ReadLine());
                        boek.WijzigVoorraad(boek, boekhandel);
                        break;
                    case 3:
                        Console.WriteLine("Boek of tijdschrift toevoegen?");
                        input = Console.ReadLine();
                        if (input == "boek")
                        {
                            Console.Write("Titel: ");
                            boek.titel = Console.ReadLine();
                            Console.Write("Prijs: ");
                            boek.prijs = Double.Parse(Console.ReadLine());
                            Console.Write("Voorraad: ");
                            boek.voorraad = Int32.Parse(Console.ReadLine());
                            boekhandel.VoegToe(boek);
                        }
                        else
                        {
                            if (input == "tijdschrift")
                            {
                                Console.Write("Titel: ");
                                weekblad.titel = Console.ReadLine();
                                Console.Write("Prijs: ");
                                weekblad.prijs = Double.Parse(Console.ReadLine());
                                Console.Write("Voorraad: ");
                                weekblad.voorraad = Int32.Parse(Console.ReadLine());
                                Console.Write("Datum uitgifte (dd/mm/jjjj): ");
                                weekblad.dagVanUitgifte = Console.ReadLine();
                                boekhandel.VoegToe(weekblad);
                            }
                            else
                            {
                                Console.WriteLine("Ongeldige invoer");
                            }
                        }
                        break;
                }
            }
        }
    }
}