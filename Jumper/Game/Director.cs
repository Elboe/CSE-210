    public class Director
    {
        
        private char playerGuess = '0';
        private Jumper jumper = new Jumper();
        private bool keepPlaying = true; 
        private Puzzle puzzle = new Puzzle();
        private Terminal terminal = new Terminal();
        private bool isGaming;
        private string playerContinueResponse = "";


        public void StartGame()
      {
        while(keepPlaying) // loops the game
        { 
            jumper.SetNewJumper(puzzle);
            isGaming = true;
            while(isGaming) // loops the game functions
            {
                GetInputs();
                puzzle.GetGuesses(playerGuess);
                DoUpdates();
                DoOutputs();
            }
            ContinueGame();
        }   
      }
      // constructor
        public Director()
        {

        }
        // methods
        public void GetInputs() // prompts the user
        {
            terminal.DisplayPrompt();
            playerGuess = char.Parse(Console.ReadLine());
            

        }
        private void DoUpdates() // updates the jumper and letters
        {
            jumper.SetCurrentStatus(playerGuess, puzzle);
            terminal.DisplayStatus(jumper);
            terminal.DisplayScene(jumper);
        }
        private void DoOutputs() //5 guesses = game over
                                // no more "_" = epic win

        { 
            
                if (jumper.GetChuteDamage() == 5) //check if damage = 5
                {
                    terminal.DisplayLose(); // jumper is kill :(
                    isGaming = false;
                } 
                else if (!jumper.GetStatus().Contains('_')){ //check if there are any "_"
                    terminal.DisplayWin();  //epic win!!!!
                    isGaming = false;
                }
            
            }  


    
        private void ContinueGame() //ask if you want to play again
        {
            terminal.DisplayContinue();
            playerContinueResponse = Console.ReadLine();
            if(playerContinueResponse == "y"){
                keepPlaying = true;
            }
            else if(playerContinueResponse == "n"){
                keepPlaying = false;
            }
        }
    }
     
   
   




