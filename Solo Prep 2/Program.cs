// Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade.

Console.Write("What is your grade percentage? ");
string ?input = Console.ReadLine();
int grade = int.Parse(input!);
string letterGrade;

if (grade >= 90)
{
    letterGrade = "A";
}
else if (grade <= 90 && grade >= 80)
{
    letterGrade = "B";
}
else if (grade <= 80 && grade >= 70)
{
    letterGrade = "C";
}
else if (grade <= 70 && grade >= 60)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}

Console.WriteLine($"You got a {letterGrade}");

/* Assume that you must have at least a 70 to pass the class. 
After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, 
and if so display a message to congratulate them. 
If not, display a different message to encourage them for next time. */

if (letterGrade == "D" || letterGrade == "F")
{
    Console.WriteLine("You failed you fucking idiot!");
}
else
{
    Console.WriteLine("Epic Win!!!");
}

/* Change your code from the first part, so that instead of printing the letter grade in the body of each if,
 elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.*/