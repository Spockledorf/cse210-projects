using System.Diagnostics;

public class ListingActivity : Activity
{
    int _count = 0;
    private List<string> _prompts = new List<string>();
    private HashSet<int> _usedPromptsIndex = new HashSet<int>();

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
        List<string> responses = GetListFromUser();
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items!");


        // End of unique activity
        DisplayEndingMessage();
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowSpinner(5, true);
        Console.Clear();
        Console.WriteLine($"  --- {prompt} ---");
    }
    public string GetRandomPrompt()
    {
        if (_usedPromptsIndex.Count >= _prompts.Count)
        {
            _usedPromptsIndex.Clear();
        }

        int randomIndex;

        do
        {
            randomIndex = Random.Shared.Next(0, _prompts.Count);
        } while (_usedPromptsIndex.Contains(randomIndex));

        _usedPromptsIndex.Add(randomIndex);

        return _prompts[randomIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("  > ");
            responses.Add(Console.ReadLine());
        }
        return responses;
    }
}