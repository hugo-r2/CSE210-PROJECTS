using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        Random randomGenerator = new Random();

        int numberConverted = randomGenerator.Next(1, 11);
        int guess = -1;
        string newNumber = "X";

        while (guess != numberConverted)
        {
            Console.Write("What is your guess? ");
            newNumber = Console.ReadLine();
            int newNumberConverted = int.Parse(newNumber);
            guess = newNumberConverted;

            if (guess > numberConverted)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < numberConverted)
            {
                Console.WriteLine("Higher");
            }

        }

        Console.WriteLine("Congratulations you Guessed it!");

    }
}