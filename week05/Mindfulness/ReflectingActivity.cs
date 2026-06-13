public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        // Construct
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        DisplayStartingMessage();
        _duration = GetValidatedDuration();
        // Unique Activity here

        // End of unique activity
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(0, _prompts.Count);
        
        // Improvement idea: add list of used strings via indexes.
        
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        int randomIndex = Random.Shared.Next(0, _prompts.Count);
        
        // Improvement idea: add list of used strings via indexes.
        
        return _questions[randomIndex];
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