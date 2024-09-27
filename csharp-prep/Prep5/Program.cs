using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = NamePrompt();
        int number = FavoriteNumber();
        int multipliedNumber = SquareCalculation(number);

        FinalPrompt(name, multipliedNumber);




        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string NamePrompt()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;

        }

        static int FavoriteNumber()

        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int numberConverted = int.Parse(number);
            return numberConverted;
        }

        static int SquareCalculation(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void FinalPrompt(string name, int multipliedNumber)

        {
            Console.WriteLine($"{name}, the square of your number is {multipliedNumber}");

        }
    }
}