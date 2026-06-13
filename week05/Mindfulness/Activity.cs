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

    public void ShowCountdown(int seconds)
    {
        // Countdown logic
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int updateSpeed = 100;
        
        // Character pool: [▌ ▀ ▐ ▄] [▖ ▘ ▝ ▗] [| / — \] [▰ ▱ ▱ ▱]
        
        int barLength = 20;

        while (DateTime.Now < futureTime)
        {
            // How far through the duration are we?
            double elapsed = (DateTime.Now - startTime).TotalSeconds;
            int filled = (int)Math.Round((elapsed / seconds) * barLength);
            filled = Math.Clamp(filled, 0, barLength);

            string bar = new string('▓', filled) + new string('░', barLength - filled);
            string frame = $"[ {bar} ]";
            int charCount = frame.Length;

            Console.Write(frame);
            Thread.Sleep(updateSpeed);
            Console.Write(new string('\b', charCount) + new string(' ', charCount) + new string('\b', charCount));
        }
    }
}