public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Construct
    }
    public void Run()
    {
        // Run logic here
    }
    public string GetRandomPrompt()
    {
        return "prompt";
    }
    public string GetRandomQuestion()
    {
        return "question";
    }
    public void DisplayPrompt()
    {
        // Display prompt logic
    }
    public void DisplayQuestions()
    {
        // Display questions logic
    }
}