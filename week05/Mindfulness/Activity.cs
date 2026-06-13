using System.Diagnostics;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        // Start message
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine($"{_description}");


    }
    public void DisplayEndingMessage()
    {
        // End message
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}!");

    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int spinnerSpeed = 100;

        // Character pool: [▌ ▀ ▐ ▄] [▖ ▘ ▝ ▗] [| / — \] [▰ ▱ ▱ ▱]

        List<string> frames = [" ▌ ", " ▀ ", " ▐ ", " ▄ "];
        int frameCount = frames.Count();
        int frame = 0;

        while (DateTime.Now < futureTime)
        {

            string current = frames[frame];
            int charCount = current.Length;

            Console.Write(current);
            Thread.Sleep(spinnerSpeed);
            Console.Write(new string('\b', charCount) + new string(' ', charCount) + new string('\b', charCount));

            frame++;
            if (frame == frameCount)
            {
                frame = 0;
            }
        }
    }

    public void ShowProgressBar(int seconds, int barLength, bool isLeftToRight)
    {
        var barProgressClock = Stopwatch.StartNew();

        int updateSpeed = 100;

        while (barProgressClock.Elapsed.TotalSeconds < seconds)
        {
            double elapsed = barProgressClock.Elapsed.TotalSeconds;
            int filled = (int)Math.Round(elapsed / seconds * barLength);
            filled = Math.Clamp(filled, 1, barLength);

            string filledChars = new string('█', filled);
            string emptyChars = new string('-', barLength - filled);
            string bar;
            if (isLeftToRight)
            {
                bar = filledChars + emptyChars;
            }
            else
            {
                bar = emptyChars + filledChars;
            }

            // string frame = $"| {bar} | {elapsed:F0}s / {seconds}s";
            string frame = $"| {bar} |";
            int charCount = frame.Length;

            Console.Write(frame);
            Thread.Sleep(updateSpeed);
            Console.Write(new string('\b', charCount) + new string(' ', charCount) + new string('\b', charCount));
        }

        // Write the completed bar
        // string completed = $"| {new string('█', barLength)} | {seconds}s / {seconds}s";
        string completed = $"| {new string('█', barLength)} |";
        Console.WriteLine(completed);
    }
    public int GetValidatedDuration()
    {
        Console.WriteLine();
        int duration = 0;
        bool invalidDuration = true;

        while (invalidDuration)
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            Console.Write("  > ");

            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                invalidDuration = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid number of seconds.");
            }
        }

        return duration;
    }
}