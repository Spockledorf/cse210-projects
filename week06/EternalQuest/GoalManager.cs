using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>
    
    private bool _running;
    private Stopwatch _timeTracker = Stopwatch.StartNew();
    private readonly List<string> _menuOptions = [
        "Create New Goal",  // 1
        "List Goals",       // 2
        "Save Goals",       // 3
        "Load Goals",       // 4
        "Record Event",     // 5
        "Clear Save",       // 6
        "Quit"              // 7
    ];

    public GoalManager()
    {
        _running = true;
    }

    public void Start()
    {
        while (_running)
        {
            DisplayMenu(_menuOptions);
            int option = GetUserIntSelect(_menuOptions.Count);

            switch (option)
            {
                case 1:
                    // Create New Goal
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 2:
                    // List Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 3:
                    // Save Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 4:
                    // Load Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 5:
                    // Record Event
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 6:
                    // Clear Goals from list
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 7:
                    // Quit
                    Console.WriteLine($"Selected: '{_menuOptions[option-1]}'");
                    ShowLoadingBar(3, 70);
                    _running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowLoadingBar(3, 50);
                    Console.Clear();
                    break;
            }
        }
    }

    private void DisplayMenu(List<string> _menuOptions)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");

        // Display Menu options
        int count = 0;
        foreach (string option in _menuOptions)
        {
            count++;
            Console.WriteLine($"{count}. {_menuOptions[count - 1]}");
        }
        // Console.Write("Select a choice from the menu: ");
    }

    public int GetUserIntSelect(int upperBound, int lowerBound = 1)
    {
        // Fixes Range flip
        if (upperBound < lowerBound)
        {
            int temp1 = upperBound;
            int temp2 = lowerBound;
            upperBound = temp2;
            lowerBound = temp1;
        }

        while (true)
        {
            // Console.Write($"Enter a number between {lowerBound} and {upperBound}: ");
            Console.WriteLine($"Please enter selection: (integer between {lowerBound} and {upperBound})");
            Console.Write("  > ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int selection) &&
                selection >= lowerBound &&
                selection <= upperBound)
            {
                return selection;
            }

            Console.WriteLine($"Invalid input. Please enter a integer between {lowerBound} and {upperBound}.");
        }
    }

    public void ShowLoadingBar(int seconds, int spinnerSpeed = 100, bool isTimeDisplayed = false)
    {
        var spinnerClock = Stopwatch.StartNew();
        Console.CursorVisible = false;

        // Character pool: [▌ ▀ ▐ ▄] [▖ ▘ ▝ ▗] [| / — \] [▰ ▱ ▱ ▱] [■ □]
        List<string> frames = [
            "□ □ □ □ □ □ □",
            "■ □ □ □ □ □ □",
            "■ ■ □ □ □ □ □",
            "■ ■ ■ □ □ □ □",
            "□ ■ ■ ■ □ □ □",
            "□ □ ■ ■ ■ □ □",
            "□ □ □ ■ ■ ■ □",
            "□ □ □ □ ■ ■ ■",
            "□ □ □ □ □ ■ ■",
            "□ □ □ □ □ □ ■"
        ];
        int frameCount = frames.Count;
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
                current = current + $" {(int)(seconds - elapsed)}s  ";
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

        Console.CursorVisible = true;
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