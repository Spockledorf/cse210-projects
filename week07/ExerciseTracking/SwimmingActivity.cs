public class SwimmingActivity : Activity
{
    private int _lapCount;

    public SwimmingActivity(int day, string month, int year, int duration, int lapCount) : base(day, month, year, duration)
    {
        _lapCount = lapCount;
    }
    
    public override double GetDistance()
    {
        return _lapCount * 50 / 1000 * 0.62; // miles = swimming laps * 50 / 1000 * 0.62
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}