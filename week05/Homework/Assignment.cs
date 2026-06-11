// Responsibility: TODO 
// Behavior: TODO
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        // Returns summary of assignment
        return $"{_studentName} - {_topic}";
    }
}