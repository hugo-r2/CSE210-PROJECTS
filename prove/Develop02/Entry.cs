public class Entry
{
    public string _newEntry = "";
    public string _date;
    public string _prompt = "";
    public string _location = "";
    public string _mood = "";

    public void DisplayJournal()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_newEntry}");
        Console.WriteLine($"{_location}");
        Console.WriteLine($"{_mood}");

        Console.WriteLine("");

    }

    public override string ToString()
    {
        return $"{_date}|{_prompt}|{_newEntry}|{_location}|{_mood}";
    }
}