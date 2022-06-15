using System;  

namespace Greed.Game.Casting
{
    // takes away points from player
    public class Rock : Actor
    {
        // properties
        private int score = -10;

        // constructor
        public Rock()
        {

        }

        // gets score
        public int getScore()
        {
            return score;
        }
    }
}