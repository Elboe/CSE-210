namespace cse210_hilo.Game
{
    
    public class Card
    {
        // class fields

        public int firstCard;
        public int secondCard;
        
        // constructor
        public Card()
        {
            firstCard = 0;
            secondCard = RandomCard(); //make random num
            
            /*
            if Director.GetGuess.guess == h but h is false: score -75
            if Director.GetGuess.guess == h but h is true: score +100
            if Director.GetGuess.guess == l but l is false: score -75
            if Director.GetGuess.guess == l but l is true: score +100
            */

        }

        // moves the secondCard value to firstCard and picks a new random value for secondCard
        public void DrawCard()
        {
            firstCard = secondCard; //move 2nd to 1st
            secondCard = RandomCard(); //make random into 2nd
        }
        
        // Selects a random value from 1 through 13 and returns it.
        private int RandomCard()
        {
            Random random = new Random();
            int value = random.Next(1,14);
            return value;
        }
    }
}