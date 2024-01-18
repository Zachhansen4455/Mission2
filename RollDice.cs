using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    //create class to roll the dice
    public class RollDice
    {
        //this with generate the 2 dice rolls and sum them up
        public int[] rollTheDice(int NumOfRolls)
        {
            // create function to do random
            Random random = new Random();
            //make an array to store the total number of roll sums
            int[] rolltotals = new int[11];

            // for loop to through and roll the two dice and get their sum then add them to the array
            for (int rollNumber = 1; rollNumber <= NumOfRolls; rollNumber++)
            {
                int dice1 = RollResult(random);
                int dice2 = RollResult(random);
                int diceSum = dice1 + dice2;

                rolltotals[diceSum - 2]++;
            }
            return rolltotals;
        }
        //set the random function
        static int RollResult(Random random)
        {
            return random.Next(1, 7);
        }
    }
}
