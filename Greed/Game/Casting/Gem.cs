using System;  

namespace Greed.Game.Casting
{
    // give player points
    public class Gem : Actor
    {
        // properties
        private int score = 10;

        public Gem()
        {
            
        }

        public int getScore()
        {
            return score;
        }
    }
}