// Responsibility: TODO 
// Behavior: TODO
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Returns summary of assignment
        return $"{_title} by {_studentName}";
    }
}