using System.Diagnostics;
using Microsoft.VisualBasic;

public class ActivityManager
{
    private bool _running;
    private Stopwatch _timeTracker = Stopwatch.StartNew();
    public ActivityManager()
    {
        _running = true;
    }

    public void Start()
    {
        while (_running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;
                case "2":
                    StartReflectingActivity();
                    break;
                case "3":
                    StartListingActivity();
                    break;
                case "4":
                    _running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.", 0);
        breathingActivity.Run();
    }

    private void StartReflectingActivity()
    {
        // TODO: instantiate and start your reflecting activity
    }

    private void StartListingActivity()
    {
        // TODO: instantiate and start your listing activity
    }

    public void DisplayTotalTime()
    {
        // Display elapsed time
        // 00m 00s
        int elapsedMin = _timeTracker.Elapsed.Minutes;
        int elapsedSec = _timeTracker.Elapsed.Seconds;
        Console.WriteLine($"{elapsedMin:D2}m {elapsedSec:D2}s");
    }
}