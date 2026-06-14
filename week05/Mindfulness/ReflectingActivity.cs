using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private HashSet<int> _usedPromptsIndex = new HashSet<int>(); // Used HashSet, as it can't have duplicate values and has a faster lookup time.
    private HashSet<int> _usedQuestionsIndex = new HashSet<int>();

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

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3, false);

        // Display prompt and pause
        Console.Clear();
        DisplayPrompt();

        // Display questions
        // Console.Clear();
        DisplayQuestions();

        // End of unique activity
        DisplayEndingMessage();
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
    public string GetRandomQuestion()
    {
        if (_usedQuestionsIndex.Count >= _questions.Count)
        {
            _usedQuestionsIndex.Clear();
        }

        int randomIndex;

        do
        {
            randomIndex = Random.Shared.Next(0, _questions.Count);
        }
        while (_usedQuestionsIndex.Contains(randomIndex));

        _usedQuestionsIndex.Add(randomIndex);

        return _questions[randomIndex];
    }
    public void DisplayPrompt()
    {
        // Display prompt logic
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowSpinner(5, true);
        Console.Clear();
        Console.WriteLine($"  --- {prompt} ---");
    }
    public void DisplayQuestions()
    {
        // Display questions logic
        var timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write(GetRandomQuestion());
            ShowSpinner(10, false);
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}