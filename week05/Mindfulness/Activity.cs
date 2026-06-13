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
    }
    public void DisplayEndingMessage()
    {
        // End message
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

    public void ShowProgressBar(int seconds)
    {
        var stopwatch = Stopwatch.StartNew();
        
        int updateSpeed = 100;
        int barLength = 30;

        while (stopwatch.Elapsed.TotalSeconds < seconds)
        {
            double elapsed = stopwatch.Elapsed.TotalSeconds;
            int filled = (int)Math.Round(elapsed / seconds * barLength);
            filled = Math.Clamp(filled, 1, barLength);

            string bar = new string('█', filled) + new string('-', barLength - filled);
            string frame = $"| {bar} | {elapsed:F0}s / {seconds}s";
            int charCount = frame.Length;

            Console.Write(frame);
            Thread.Sleep(updateSpeed);
            Console.Write(new string('\b', charCount) + new string(' ', charCount) + new string('\b', charCount));
        }

        // Write the completed bar
        string completed = $"| {new string('█', barLength)} | {seconds}s / {seconds}s";
        Console.WriteLine(completed);
    }
}