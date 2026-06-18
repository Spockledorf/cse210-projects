using System.Drawing;

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

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            Console.WriteLine($"Yay! You completed your goal! Enjoy {_points} points!");
            SetCompleteStatus(true);
            return _points;
        }
        else
        {
            Console.WriteLine($"You have already completed this goal! No points added.");
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // Get Details logic 
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

}