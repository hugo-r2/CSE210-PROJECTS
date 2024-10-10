public class Display
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        Console.WriteLine("Entries: ");

        foreach (Entry entry in _entries)

        {
            entry.DisplayJournal();
        }
    }
}