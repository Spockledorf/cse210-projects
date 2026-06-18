public abstract class Activity
{
    private string _dateDay;
    private string _dateMonth;
    private int _dateYear;
    private int _duration = 0;

    public Activity(string day, string month, int year)
    {
        _dateDay = day;
        _dateMonth = month;
        _dateYear = year;
    }

    public abstract string GetSummary();
    public abstract double GetDistance();
}