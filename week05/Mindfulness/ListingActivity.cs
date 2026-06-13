public class ListingActivity : Activity
{
    int _count = 0;
    public List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        // Construct
        _prompts = prompts;
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
}