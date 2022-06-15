using System;  

namespace Greed.Game.Casting
{
    // keeps track of the players score
    public class Score
    {
        // properties
        private int score = 100;

        // constructor
        public Score()
        {

        }

        // gets score
        public int getScore()
        {
            return score;
        }

        // changes score
        public void updateScore(int score)
        {
            this.score += score;
        }
    }
}