using System.Diagnostics;

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

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3, false);
        
        // Display prompt and pause
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowSpinner(5, true);

        // Display questions
        Console.Clear();
        DisplayQuestions();

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
        int randomIndex = Random.Shared.Next(0, _questions.Count);

        // Improvement idea: add list of used strings via indexes.

        return _questions[randomIndex];
    }
    public void DisplayPrompt()
    {
        // Display prompt logic
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"  --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        // Display questions logic
        var timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10, false);
        }
        
        Console.WriteLine();
    }
}