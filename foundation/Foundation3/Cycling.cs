
public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) 
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed / 60) * LengthInMinutes;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
