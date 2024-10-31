using System.Collections.Generic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public void Run(int duration)
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each one of these questions:");
        ShowSpinner(3);

        List<string> askedQuestions = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion(askedQuestions);
            if (question != null)
            {
                Console.WriteLine(question);
                ShowSpinner(4);
            }
            else
            {
                break;
            }
        }

        DisplayEndingMessage(duration, _name);
    }

    private string GetRandomQuestion(List<string> askedQuestions)
    {
        List<string> availableQuestions = new List<string>(_questions);
        availableQuestions.RemoveAll(q => askedQuestions.Contains(q));

        if (availableQuestions.Count > 0)
        {
            Random rand = new Random();
            string selectedQuestion = availableQuestions[rand.Next(availableQuestions.Count)];
            askedQuestions.Add(selectedQuestion);
            return selectedQuestion;
        }
        return null;
    }
}
