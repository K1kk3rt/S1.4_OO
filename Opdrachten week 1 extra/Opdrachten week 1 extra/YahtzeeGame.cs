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
                Console.Write(dobbelstenen[i]);
            }
            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            bool yahtzee = false;


            //check if all values in array are the same
            if (dobbelstenen.Distinct().Count() == 1)
            {
                yahtzee = true;
            }
            return yahtzee;
        }

        public bool ThreeOfAKind()
        {
            bool threeofakind = false;

            Array.Sort(dobbelstenen);
            int counter = 1;

            for (int i = 0; i < dobbelstenen.Length; i++)
            {

                if (i < dobbelstenen.Length - 1)
                {
                    // two consecutive die values, increment the counter
                    if (dobbelstenen[i] == dobbelstenen[i + 1])
                    {
                        counter++;

                        // if the counter = the X of a kind (3, 4, or 5), flag it
                        if (counter == 3)
                        {
                            threeofakind = true;
                        }
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            return threeofakind;
        }

        public bool FourOfAKind()
        {
            bool fourofakind = false;

            Array.Sort(dobbelstenen);
            int counter = 1;

            for (int i = 0; i < dobbelstenen.Length; i++)
            {

                if (i < dobbelstenen.Length - 1)
                {
                    // two consecutive die values, increment the counter
                    if (dobbelstenen[i] == dobbelstenen[i + 1])
                    {
                        counter++;

                        // if the counter = the X of a kind (3, 4, or 5), flag it
                        if (counter == 4)
                        {
                            fourofakind = true;
                        }
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            return fourofakind;
        }
    }
}
