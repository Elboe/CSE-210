    public class Jumper
    {
        // Keeps track of damage and letters guessed

        // fields
        private int chuteDamage = 0;
        private List<char> currentStatus = new List<char>();
        Puzzle puzzle = new Puzzle();
        private string newWord = ""; 
        private List<char> chars = new List<char>();
        private List<int> correctIndexes = new List<int>();
        private bool isCorrectGuess;
                
        // constructor
        public Jumper()
        {
            
        }

        // methods

        // makes new blanks, sets damage to zero
        public void SetNewJumper(Puzzle puzzle)
        {
            newWord = puzzle.WordList();
            chars = puzzle.LettersNeeded(newWord);
            for (int i = 0; i < chars.Count; i++){
                currentStatus.Add('_');
            }
            chuteDamage = 0;
        }

        // turns _ into letter if correct, or adds to damage
        public void SetCurrentStatus(char guess, Puzzle puzzle)
        {  
            isCorrectGuess = false;
            for (int i = 0; i < correctIndexes.Count; i++ ){
                if (correctIndexes[i] != -1){
                    currentStatus[i] = guess;
                    isCorrectGuess = true;
                }
            }
            if (!isCorrectGuess){
                chuteDamage ++;
            }
        }

        // returns damage
        public int GetChuteDamage()
        {  
            return chuteDamage;
        } 

        // returns guessed letters and remaining underscores
        public List<char> GetStatus()
        {  
            return currentStatus;
        } 
    }