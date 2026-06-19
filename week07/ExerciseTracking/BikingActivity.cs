public class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(int day, string month, int year, int duration, double speed) : base(day, month, year, duration)
    {
        _speed = speed;
    }
    
    public override double GetDistance()
    {
        return _speed * GetDuration() / 60;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}