public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int day, string month, int year, int duration, double distance) : base(day, month, year, duration)
    {
        _distance = distance;
    }
    
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}