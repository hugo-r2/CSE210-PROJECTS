
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.") { }

    // Run the breathing activity for a specified duration
    public void Run(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            CountDown(); // Countdown from 4 to 0
            Console.Write("Breathe out...");
            CountDown();
            Console.WriteLine();
        }

        DisplayEndingMessage(duration, _name); // Show ending message
    }

    // Countdown from 4 to 0 with a pause
    private void CountDown()
    {
        for (int i = 4; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
