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
            // probeer yahtzee te gooien
            int aantalPogingen = 0;
            do
            {
                // gooi alle dobbelstenen
                yahtzeeGame.Gooi();
                aantalPogingen++;
            } while (!yahtzeeGame.Yahtzee());
            // vermeld aantal pogingen voor yahtzee
            Console.WriteLine("Aantal pogingen nodig: {0}", aantalPogingen);
            // wacht op gebruiker
            Console.ReadKey();
        }
    }
}
