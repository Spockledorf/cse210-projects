public class SwimmingActivity : Activity
{
    private int _lapCount;

    public SwimmingActivity(int day, string month, int year, int duration, int lapCount) : base(day, month, year, duration)
    {
        _lapCount = lapCount;
    }
    
    // TODO
}