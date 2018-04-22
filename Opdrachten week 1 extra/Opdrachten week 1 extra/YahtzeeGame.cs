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


        /// <summary>
        /// CalcX determines the total of a specified die value of a collection of dice
        /// </summary>
        /// <param name="dieValue">value of the dice to be totalled (1s, 2s, ... 6s)</param>
        /// <returns>the total of the specified die value in the collection of dice</returns>
        public int CalcX(int dieValue)
        {
            int total = 0;

            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                if (dobbelstenen[i] == dieValue)
                {
                    total += dobbelstenen[i];
                }
            }

            return total;
        }

        /// <summary>
        /// calculate X of a kind total (where X = {3, 4, 5} based on dieValue)
        /// </summary>
        /// <param name="dieValue">determines the Yahtzee field to calculate</param>
        /// <param name="gameDice">the collection of dice</param>
        /// <returns>the total of the dice, if a X of a kind exists, or 0</returns>
        public bool XOfAKind(int numOfAKind)
        {
            int total = 0;
            int counter = 1;
            bool isXOfAKind = false;

            // sort the dice array
            Array.Sort(dobbelstenen);

            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                // sum up all the dice
                total += dobbelstenen[i];

                if (i < dobbelstenen.Length - 1)
                {
                    // two consecutive die values, increment the counter
                    if (dobbelstenen[i] == dobbelstenen[i + 1])
                    {
                        counter++;

                        // if the counter = the X of a kind (3, 4, or 5), flag it
                        if (numOfAKind == counter)
                        {
                            isXOfAKind = true;
                        }
                    }
                    else
                    {
                        // two consecutive die values do not equate, start the counter over
                        counter = 1;
                    }
                }
            }

            return isXOfAKind;
        }

        /// <summary>
        /// calculate whether or not a full house (2 of a kind + 3 of a kind) is possible
        /// </summary>
        /// <returns>the total of 25, if a full house exists, or 0</returns>
        public bool FullHouse()
        {
            bool setOf2 = false;
            bool setOf3 = false;
            bool isFullHouse = true;

            // sort the dice array
            Array.Sort(dobbelstenen);

            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                if (i < dobbelstenen.Length - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (dobbelstenen[i] != dobbelstenen[i + 1])
                            {
                                // full house not possible - in a sorted array, the first 2 values MUST be equal for a full house to exist
                                isFullHouse = false;
                            }
                            break;
                        case 1:
                            if (dobbelstenen[i] == dobbelstenen[i + 1])
                            {
                                // a set of 3 has been made
                                setOf3 = true;
                            }
                            else
                            {
                                // a set of 2 has been made
                                setOf2 = true;
                            }
                            break;
                        case 2:
                            if (dobbelstenen[i] == dobbelstenen[i + 1])
                            {
                                if (setOf3)
                                {
                                    // full house not possible - due to 4 of a kind
                                    isFullHouse = false;
                                }
                            }
                            else
                            {
                                if (setOf2)
                                {
                                    // full house not possible - due to more than two values represented in the array of dice
                                    isFullHouse = false;
                                }
                            }
                            break;
                        case 3:
                            if (dobbelstenen[i] != dobbelstenen[i + 1])
                            {
                                // full house not possible - in a sorted array, the last 2 values MUST be equal for a full house to exist
                                isFullHouse = false;
                            }
                            break;
                        default:
                            // do nothing
                            break;
                    }
                }
            }
            return isFullHouse;
        }

        /// <summary>
        /// calculate whether or not a straight (small or large) is possible
        /// </summary>
        /// <param name="wantLargeStraight">true for large straight, false for small straight</param>
        /// <returns>the total of 40 if a large straight exists, 30 if a small straight exists, or 0</returns>
        public bool Straight(bool wantLargeStraight)
        {
            bool isStraight = true;
            bool smallStraightPassUsed = false;

            // sort the dice array
            Array.Sort(dobbelstenen);

            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                if (i < dobbelstenen.Length - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (dobbelstenen[i] != dobbelstenen[i + 1] - 1)
                            {
                                if (wantLargeStraight)
                                {
                                    // large straight not possible - each of the 5 dice values MUST be consecutively one less than the next
                                    isStraight = false;
                                }
                                else
                                {
                                    smallStraightPassUsed = true;
                                }
                            }
                            break;
                        case 1:
                        case 2:
                            if (dobbelstenen[i] != dobbelstenen[i + 1] - 1)
                            {
                                // straight not possible - the first 4 dice OR, the last 4 dice, values MUST be consecutively one less than the next
                                isStraight = false;
                            }
                            break;
                        case 3:
                            if (dobbelstenen[i] != dobbelstenen[i + 1] - 1)
                            {
                                if (wantLargeStraight)
                                {
                                    // large straight not possible - each of the 5 dice values MUST be consecutively one less than the next
                                    isStraight = false;
                                }
                                else
                                {
                                    if (smallStraightPassUsed)
                                    {
                                        // small straight not possible - must have 4 consecutive values of one less than the next
                                        isStraight = false;
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            return isStraight;
        }
    }
}
