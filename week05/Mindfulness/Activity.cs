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
        // spiiner logic
    }

    public void ShowCountdown(int seconds)
    {
        // Countdown logic
    }
}