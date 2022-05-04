using System.Collections.Generic;


List<int> numbers = new List<int>();
string ?input;
int sum = 0;

Console.WriteLine("Please enter a list of numbers. Enter 0 when finished:");

do
{
    Console.Write("Enter a number: ");
    input = Console.ReadLine();
    int intput = int.Parse(input!);
    numbers.Add(intput);
} while (input != "0");

foreach (int number in numbers)
{
    sum += number;
}
float average = sum / (numbers.Count - 1);

Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");