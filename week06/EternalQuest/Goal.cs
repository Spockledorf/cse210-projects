public class Goal
{
    private string _shortName = "";
    private string _description = "";
    private int _points = -1;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    private void RecordEvent()
    {
        // Record event logic 
    }
    private bool IsComplete()
    {
        // Is complete logic
        return false; 
    }
    private string GetDetailsString()
    {
        // Get Details logic 
        return "";
    }
    private string GetStringRepresentation()
    {
        // Get string rep logic 
        return "";
    }
}