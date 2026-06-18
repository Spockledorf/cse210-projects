public abstract class Activity
{
    private string _dateDay;
    private string _dateMonth;
    private int _dateYear;
    private int _duration; // Minutes

    public Activity(string day, string month, int year, int duration)
    {
        _dateDay = day;
        _dateMonth = month;
        _dateYear = year;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return $"{_dateDay} {_dateMonth} {_dateYear}";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}