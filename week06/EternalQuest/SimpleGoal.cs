public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Goal is not complete by default, must record 
    }   
    
    public void SetCompleteStatus(bool isGoalComplete)
    {
        _isComplete = isGoalComplete;
    }
    public void SetIncomplete()
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

}