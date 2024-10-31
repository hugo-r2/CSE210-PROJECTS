public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; set; }
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) 
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        AmountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (AmountCompleted < _target)
        {
            AmountCompleted++;
        }
    }

    public override bool IsComplete() => AmountCompleted >= _target;

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{AmountCompleted}";

    public override string GetDetailsString() => IsComplete() 
        ? $"[X] {_shortName}: {_description} (Completed {AmountCompleted}/{_target})" 
        : base.GetDetailsString() + $" (Completed {AmountCompleted}/{_target})";
}
