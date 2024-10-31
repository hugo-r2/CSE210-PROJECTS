using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private LevelManager _levelManager;
    private const string FilePath = "goals.txt";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levelManager = new LevelManager();
        LoadGoals();
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "simple")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "eternal")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "checklist")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for completion: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Unknown goal type.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter the name of the goal you want to record an event for: ");
        string name = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal.GetStringRepresentation().Contains(name))
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                Console.WriteLine($"Event recorded for goal: {name}. You earned {goal.GetPoints()} points!");
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        _levelManager.CheckLevelUp(_score);
        Console.WriteLine($"Current Level: {_levelManager.Level}");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    private void LoadGoals()
    {
        if (File.Exists(FilePath))
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts[0] == "SimpleGoal")
                    {
                        var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) 
                        {
                            simpleGoal.RecordEvent(); 
                        }
                        _goals.Add(simpleGoal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]))
                        {
                            AmountCompleted = int.Parse(parts[6])
                        });
                    }
                }
            }
            Console.WriteLine("Goals and score loaded successfully.");
        }
    }
}
