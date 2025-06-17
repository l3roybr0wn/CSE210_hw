public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
