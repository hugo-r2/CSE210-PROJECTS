public class ActivityTracker
{
    private int _breathingCount;
    private int _reflectingCount;
    private int _listingCount;

    public void IncrementBreathingCount()
    {
        _breathingCount++;
    }

    public void IncrementReflectingCount()
    {
        _reflectingCount++;
    }

    public void IncrementListingCount()
    {
        _listingCount++;
    }

    public void DisplayActivityLog()
    {
        Console.WriteLine("Activity Log:");
        Console.WriteLine($"Breathing Activities: {_breathingCount}");
        Console.WriteLine($"Reflecting Activities: {_reflectingCount}");
        Console.WriteLine($"Listing Activities: {_listingCount}");
        Console.WriteLine();
    }
}
