using System.Diagnostics;

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

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3, false);
        
        // Display prompt and pause
        Console.Clear();
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowSpinner(5, true);
        Console.Clear();
        List<string> responses = GetListFromUser();
        _count = responses.Count;

        // End of unique activity
        DisplayEndingMessage();
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }
    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(0, _prompts.Count);
        
        // Improvement idea: add list of used strings via indexes.

        return _prompts[randomIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DisplayPrompt();
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("  > ");
            responses.Add(Console.ReadLine());
            Console.WriteLine();
        }
        return responses;
    }
}