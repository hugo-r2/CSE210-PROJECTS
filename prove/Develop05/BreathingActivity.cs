
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.") { }

    public void Run(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            CountDown();
            Console.Write("Breathe out...");
            CountDown();
            Console.WriteLine();
        }

        DisplayEndingMessage(duration, _name);
    }


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
