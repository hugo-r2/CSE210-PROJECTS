using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }

    public void DisplayEndingMessage(int duration, string activityType)
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You finished another {duration} seconds {activityType} activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
