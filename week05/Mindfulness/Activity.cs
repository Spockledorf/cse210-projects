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
        ShowSpinner(5, false);
    }
    public void ShowSpinner(int seconds, bool isTimeDisplayed)
    {
        var spinnerClock = Stopwatch.StartNew();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int spinnerSpeed = 120;

        // Character pool: [▌ ▀ ▐ ▄] [▖ ▘ ▝ ▗] [| / — \] [▰ ▱ ▱ ▱]

        List<string> frames = [" ▌ ", " ▀ ", " ▐ ", " ▄ "];
        int frameCount = frames.Count();
        int frame = 0;
        string current;
        double elapsed;
        int charCount;

        while (spinnerClock.Elapsed.TotalSeconds < seconds)
        {
            elapsed = spinnerClock.Elapsed.TotalSeconds;
            current = frames[frame];
            if (isTimeDisplayed)
            {
                current = current + $" {seconds - elapsed}s";
            }
            charCount = current.Length;

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

    public void ShowProgressBar(int seconds, int barLength, bool isLeftToRight, bool isTimeDisplayed)
    {
        var barProgressClock = Stopwatch.StartNew();

        int updateSpeed = 100;

        while (barProgressClock.Elapsed.TotalSeconds < seconds)
        {
            double elapsed = barProgressClock.Elapsed.TotalSeconds;
            int filled = (int)Math.Round(elapsed / seconds * barLength);
            filled = Math.Clamp(filled, 1, barLength);

            // string filledChars = new string('█', filled);
            // string emptyChars = new string('-', barLength - filled);
            string charsLeft;
            string charsRight;
            string bar;
            if (isLeftToRight)
            {
                charsLeft = new string('█', filled);
                charsRight = new string('-', barLength - filled);
                bar = charsLeft + charsRight;
            }
            else
            {
                charsLeft = new string('-', filled);
                charsRight = new string('█', barLength - filled);
                bar = charsRight + charsLeft;
            }

            // string frame = $"| {bar} | {elapsed:F0}s / {seconds}s";
            string frame;
            if (isTimeDisplayed)
            {
                frame = $"| {bar} | {elapsed:F0}s / {seconds}s";
            }
            else
            {
                frame = $"| {bar} |";
            }
            int charCount = frame.Length;

            Console.Write(frame);
            Thread.Sleep(updateSpeed);
            Console.Write(new string('\b', charCount) + new string(' ', charCount) + new string('\b', charCount));
        }

        // Write the completed bar
        // string completed = $"| {new string('█', barLength)} | {seconds}s / {seconds}s";
        if (isLeftToRight)
        {
            Console.WriteLine($"| {new string('█', barLength)} |");
        }
        else
        {
            Console.WriteLine($"| {new string('-', barLength)} |");
        }
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