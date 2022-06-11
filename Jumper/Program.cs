namespace cse210_jumper
{
    // creates an instance of director and starts the game
    class Program
    {
        // methods
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}