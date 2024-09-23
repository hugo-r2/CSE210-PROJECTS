using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fr_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lst_name = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {lst_name}, {fr_name} {lst_name}");
    }
}