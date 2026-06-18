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

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted > _target)
        {
            Console.WriteLine($"Nicely done! You have already completed the target, but enjoy {_points} more points!");
            return _points;
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Horray! You completed the target! Enjoy {_points} points + {_bonus} bonus points!");
            return _bonus + _points;
        }
        else
        {
            Console.WriteLine($"Congratulations! You've completed another part of your target! You get {_points} points! \nComplete this goal {_target - _amountCompleted} more times to get {_bonus} more bonus points!");
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        // Get Details logic 
         string goalString;
        if (IsComplete())
        {
            goalString = $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target} (Done / Target)";
        }
        else
        {
            goalString = $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target} (Done / Target)";
        }
        return goalString;
    }
    public override string GetStringRepresentation()
    {
        // Get Details logic 
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }

}