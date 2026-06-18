public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    public readonly int _points = -1;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetNameString()
    {
        return _shortName;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        // Get Details logic 
        string goalString;
        if (IsComplete())
        {
            goalString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            goalString = $"[ ] {_shortName} ({_description})";
        }
        return goalString;
    }
    public abstract string GetStringRepresentation();
}