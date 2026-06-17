public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = -1;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        // Get Details logic 
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        // Get string rep logic 
        return "";
    }
}