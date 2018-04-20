using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_1_extra
{
    class YahtzeeGame
    {
        int[] dobbelstenen = new int[5];
        Random random = new Random();

        public YahtzeeGame()
        {
            int[] dobbelstenen = new int[5];
            Random random = new Random();
        }

        public void Gooi()
        {
            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                dobbelstenen[i] = random.Next(1, 7);
            }
        }

        public bool Yahtzee()
        {
            bool yahtzee = false;

            //check if all items in array are the same
            string firstItem = dobbelstenen[0].ToString();
            yahtzee = dobbelstenen[0].ToString().Skip(1).All(s => string.Equals(firstItem, s.ToString(), StringComparison.InvariantCultureIgnoreCase));

            return yahtzee;
        }
    }
}
