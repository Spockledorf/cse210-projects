public class ListingActivity : Activity
{
    int _count = 0;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Construct
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
        return "prompt";
    }
}