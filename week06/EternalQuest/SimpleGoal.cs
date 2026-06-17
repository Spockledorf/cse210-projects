public class SimpleGoal : Goal
{
    private bool _isComplete;

    private SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Goal is not complete by default, must record 
    }
}