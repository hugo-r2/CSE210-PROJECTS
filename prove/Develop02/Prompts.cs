public class Prompts
{
    List<string> _randomPrompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random _randomPrompt = new Random();
        int index = _randomPrompt.Next(_randomPrompts.Count);
        return _randomPrompts[index];
    }


}