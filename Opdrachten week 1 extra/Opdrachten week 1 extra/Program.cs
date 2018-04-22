using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_1_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak YahtzeeGame (struct) aan
            YahtzeeGame yahtzeeGame = new YahtzeeGame();

            while (true)
            {
                Console.WriteLine("1. Yahtzee\n2. Three Of A Kind\n3. Four Of A Kind\n4. Full House\n5. Kleine Staat \n6. Grote Straat");

                string keuze = Console.ReadLine();
                int aantalPogingen = 0;

                switch (keuze)
                {
                    case "1":
                        do
                        {
                            yahtzeeGame.Gooi();
                            aantalPogingen++;
                        } while (!yahtzeeGame.Yahtzee());
                        Console.WriteLine("Aantal pogingen nodig: {0}", aantalPogingen);
                        break;
                    case "2":
                        do
                        {
                            yahtzeeGame.Gooi();
                            aantalPogingen++;
                        } while (!yahtzeeGame.ThreeOfAKind());
                        Console.WriteLine("Aantal pogingen nodig: {0}", aantalPogingen);
                        break;
                    case "3":
                        do
                        {
                            yahtzeeGame.Gooi();
                            aantalPogingen++;
                        } while (!yahtzeeGame.FourOfAKind());
                        Console.WriteLine("Aantal pogingen nodig: {0}", aantalPogingen);
                        break;
                }



                Console.ReadKey();
            }
        }
    }
}
