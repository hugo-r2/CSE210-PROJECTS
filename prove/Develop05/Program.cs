using System;

class Program
{
    static void Main(string[] args)
    {
        string menuOption = "0";
        ActivityTracker tracker = new ActivityTracker();
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (menuOption != "4")
        {
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("What would you like to do? ");
            menuOption = Console.ReadLine();
            Console.WriteLine("");

            if (menuOption == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                breathingActivity.Run(duration);
                tracker.IncrementBreathingCount(); 
            }
            else if (menuOption == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                activity.Run(duration);
                tracker.IncrementReflectingCount();
            }
            else if (menuOption == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.DisplayStartingMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                activity.Run(duration);
                tracker.IncrementListingCount();
            }
            else if (menuOption == "4")
            {
                tracker.DisplayActivityLog();
                Console.WriteLine("Thank you for using the Mindfulness App! Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
