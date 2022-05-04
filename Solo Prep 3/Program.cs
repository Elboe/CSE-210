Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);

Console.Write("Guess the Magic number! ");
string ?input = Console.ReadLine();
int guess = int.Parse(input!);


while (guess != number)
{
    
    if (guess > number)
    {
        Console.WriteLine("Lower!");
    }

    else
    {
        Console.WriteLine("Higher!");
    }
    
    Console.Write("Guess again! ");
    input = Console.ReadLine();
    guess = int.Parse(input!);
    
    
}

Console.WriteLine("You did it!");