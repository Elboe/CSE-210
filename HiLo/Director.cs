namespace cse210_hilo.Game
{
    public class Director
    {
        //class fields
        bool isPlaying = true;
        string gameContinue = "y";
        string guessNextCard = "";
        int score;
        Card card = new Card();
        
        // constructor
        public Director()
        {

        }


        // starts the game
        public void StartGame()
        {
            score = 300;                // set score to 300
            while(isPlaying)            // repeat while we are playing
            {
                card.DrawCard();        // move second card value to first and draw a new card for second
                DoOutput();           // print the first card, gets guess from user, prints the second card
                DoUpdate();           // updates score, displays new score
                if (HasLoser())         // if the score hits 0 or lower, end game
                {
                    isPlaying = false;
                    return;
                }
                GetPlayAgain();    // ask if they want to play again
            }
        }
        
        // get next card guess
        public void GetGuess()
        {
                Console.Write("Do you want to guess higher or lower? [h/l] "); // prompts user
                guessNextCard = Console.ReadLine(); //gets input and applys it to guessNextCard
        }
        
        //asks if you want to play again
        public void GetPlayAgain()
        {
            Console.Write("Do you want to play again? [y/n] "); 
            string keepPlaying = Console.ReadLine(); // gets input and applys it to keepPlaying
            isPlaying = (keepPlaying == "y");
            Console.WriteLine("");
        }
        
        // shows user which cards were drawn
        public void DoOutput()
        {
            if (!isPlaying) // break out if we're not gaming
            {
                return;
            }
            
            Console.WriteLine($"The first card is: {card.firstCard}"); // print the first card
            GetGuess(); // gets guess from user
            Console.WriteLine($"The next card was: {card.secondCard}"); //prints the second card

        }
        
        // checks if player has lost
        public bool HasLoser()
        {
            if (score <= 0) // you lose if score is less than 0
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        
        //updates score
        public void DoUpdate()
        {
            if (card.firstCard < card.secondCard && guessNextCard == "h" || card.firstCard > card.secondCard && guessNextCard == "l"){ // if correct guess
                score += 100;
                Console.WriteLine("Insaneo Style! Score +100");
            }
            else if (card.firstCard == card.secondCard){  //if same card
                score += 50;
                Console.WriteLine("Epic fail! Score +50");
            }
            else{ //if incorrect guess
                score -= 75;
                Console.WriteLine("Major defeat! Score -75");
            }

            Console.WriteLine($"Your new score is: {score} "); //print score
        }

        
    }


}
