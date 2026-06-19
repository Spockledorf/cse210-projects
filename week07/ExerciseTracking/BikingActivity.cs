public class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(int day, string month, int year, int duration, double speed) : base(day, month, year, duration)
    {
        _speed = speed;
    }
    
    // TODO
}