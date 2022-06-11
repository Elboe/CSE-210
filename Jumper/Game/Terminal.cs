

    // displays UI
    public class Terminal
    {
        // fields
        private string turnPrompt = "Guess a letter [a-z]: ";
        private string continuePrompt = "Would you like to play again? [y/n] ";
        private string ground = "^^^^^^^";
        private string liveJumper = "   0 \n  /|\\ \n  / \\";
        private string deadJumper = "   x \n  /|\\ \n  / \\";
        private string hasLoser = "You missed too many guesses! You lose!";
        private string winnerPrompt = "You guessed the word! Great job, you win!";
        private string chuteLayer01 = "  ___";
        private string chuteLayer02 = " /   \\";
        private string chuteLayer03 = " =====";
        private string chuteLayer04 = " \\   /";
        private string chuteLayer05 = "  \\ /";


        // constructor
        public Terminal()
        {

        }

        // methods

        // prompts user for guess
        public void DisplayPrompt(){
            Console.Write(turnPrompt);
        }

        // prints status of jumper
        public void DisplayStatus(Jumper jumper){
            foreach (char i in jumper.GetStatus()){
                if (i == '_')
                {
                    Console.Write(i);
                }

                else
                {
                    Console.Write(i);
                }

                Console.Write(" ");
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
        }

        // displays the jumper
        public void DisplayScene(Jumper jumper)
        {
            if (jumper.GetChuteDamage() == 0){
                Console.WriteLine(chuteLayer01);
                Console.WriteLine(chuteLayer02);
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.WriteLine(liveJumper);
                Console.WriteLine(ground);
            }
            else if (jumper.GetChuteDamage() == 1)
            {
                Console.WriteLine(chuteLayer02);
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.WriteLine(liveJumper);
                Console.WriteLine(ground);
            }
            else if (jumper.GetChuteDamage() == 2)
            {
                Console.WriteLine(chuteLayer03);
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.WriteLine(liveJumper);
                Console.WriteLine(ground);
            }
            else if (jumper.GetChuteDamage() == 3)
            {
                Console.WriteLine(chuteLayer04);
                Console.WriteLine(chuteLayer05);
                Console.WriteLine(liveJumper);
                Console.WriteLine(ground);
            }
            else if (jumper.GetChuteDamage() == 4)
            {
                Console.WriteLine(chuteLayer05);
                Console.WriteLine(liveJumper);
                Console.WriteLine(ground);
            }
            else if (jumper.GetChuteDamage() == 5)
            {
                Console.WriteLine(deadJumper);
                Console.WriteLine(ground);
            }
            Console.WriteLine("");
        }

        //displays win text
        public void DisplayWin()
        {
            Console.WriteLine(winnerPrompt);
        }

        //displays lose text
        public void DisplayLose()
        {
            Console.WriteLine(hasLoser);
        }

        // prompts to play again
        public void DisplayContinue()
        {
            Console.Write(continuePrompt);
        }
    }