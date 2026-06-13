using System.Diagnostics;

public class ActivityManager
{
    private bool _running;
    private Stopwatch _timeTracker = Stopwatch.StartNew();
    public ActivityManager()
    {
        _running = true;
    }

    Activity myActivity = new Activity("Name", "Description", 0);

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
                    myActivity.ShowSpinner(2, false);
                    Console.Clear();
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
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
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.", 0);
        reflectingActivity.Run();
    }

    private void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized. ", 0);
        listingActivity.Run();
    }

    public void DisplayTotalTime()
    {
        // Display elapsed time
        // 00m 00s
        int elapsedMin = _timeTracker.Elapsed.Minutes;
        int elapsedSec = _timeTracker.Elapsed.Seconds;
        Console.Write($"{elapsedMin:D2}m {elapsedSec:D2}s");
    }
}