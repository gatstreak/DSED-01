using System;
using System.Collections.Generic;

namespace DSED_01
    //class for methods DSED_01
{
    public class GamePlay
    {
      
        // private List<int> SuccessfulTries = new List<int>();

        // !random number

        public int RandomGen()
        {
            Random myRandom = new Random();

            return myRandom.Next(1, 7);
        }

        /// <summary>
        /// checks for duplicate numbers in the list 
        /// </summary>
        /// <param name="SuccessTries"></param>
        /// <param name="Bomb"></param>
        /// <returns> if dupe return new value until its unique </returns>
        public int DuplicateFilter(List<int> SuccessTries, int Bomb)
        {
            if (SuccessTries.Contains(Bomb))
            {
                int newBomb = RandomGen();
                while (SuccessTries.Contains(newBomb))
                {
                    newBomb = RandomGen();
                }
                return newBomb;
            }
            return Bomb;
        }
    }
}