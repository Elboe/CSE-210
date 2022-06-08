using cse210_hilo.Game;


namespace cse210_hilo
{
    class Program
    {
        //starts program
        static void Main(string[] args)
        {
            
            Card test = new Card();
            Director director = new Director();
            director.StartGame();
        }
    }
}