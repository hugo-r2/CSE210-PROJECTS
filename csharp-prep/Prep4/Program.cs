using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -999;
        int total = 0;
        int counter = 0;
        string answer = "X";
        int largest = -100;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            number = int.Parse(answer);
            numbers.Add(number);

        }

        foreach (int newNumber in numbers)
        {
            int sum = newNumber + total;
            total = sum;
            counter++;

            if (newNumber > largest)
            {
                largest = newNumber;
            }

        }

        int average = total / (counter - 1);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}