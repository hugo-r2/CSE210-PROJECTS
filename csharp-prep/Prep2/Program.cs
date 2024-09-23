using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letter = "O";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            letter = "c";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }

        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("That is not a valid percentage.");
        }

        Console.WriteLine($"You got a: {letter}.");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("You didn't pass. Keep working hard!");
        }
    }
}