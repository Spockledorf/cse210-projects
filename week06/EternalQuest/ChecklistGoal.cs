public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus = 0;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public void SetCurrentCount(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        // Get Details logic 
        return "";
    }
    public override string GetStringRepresentation()
    {
        // Get Details logic 
        return "";
    }

}