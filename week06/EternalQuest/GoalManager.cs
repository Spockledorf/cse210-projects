using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _saveFile = "MyGoals.txt";
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
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 2:
                    // List Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 3:
                    // Save Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 4:
                    // Load Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 5:
                    // Record Event
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 6:
                    // Clear Goals from list
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(3, 70);
                    break;
                case 7:
                    // Quit
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
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

    private void DisplayPlayerInfo()
    {
        // display stats
    }
    private void ListGoalNames()
    {
        // List Goal Names
    }

    private void ListGoalDetails()
    {
        // List Goal Details
    }

    private void CreateGoal()
    {
        // Create Goal
    }
    private void RecordEvent()
    {
        // Record Goal event
    }

    private void SaveGoals()
    {
        // Save Goals to file
    }
    private void LoadGoalsFromSave(string saveFile)
    {
        // Load goals from file
        _goals.Clear(); // Removes all entries to make a clean list.
        if (!File.Exists(saveFile))
        {
            Console.WriteLine();
            Console.WriteLine("File does not exist.");
            return;
        }
        string[] lines = File.ReadAllLines(saveFile);
        string[] parts;

        foreach (string line in lines)
        {
            parts = line.Split('|');

            if (parts.Length < 4)
            {
                // invalid line --> skip line
                continue;
            }

            string goalType = parts[0].Trim();
            string goalName = parts[1].Trim();
            string goalDescription = parts[2].Trim();
            if (!int.TryParse(parts[3], out int goalPoints))
            {
                // Handle invalid value
                goalPoints = 0;
                Console.WriteLine($"Warning: Invalid int value '{parts[3]}'");
            }

            Goal? lineGoal = null;

            switch (goalType.Trim())
            {
                case "SimpleGoal":
                    if (!bool.TryParse(parts[4], out bool isGoalComplete))
                    {
                        // Handle invalid value
                        isGoalComplete = false;
                        Console.WriteLine($"Warning: Invalid bool value '{parts[4]}'");
                    }
                    // Simple Logic
                    var simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    simpleGoal.SetCompleteStatus(isGoalComplete);
                    lineGoal = simpleGoal;
                    break;
                case "EternalGoal":
                    // Eternal Logic
                    lineGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    break;
                case "ChecklistGoal":
                    // Checklist Logic
                    if (parts.Length >= 7)
                    {
                        int.TryParse(parts[4], out int bonusPoints);
                        int.TryParse(parts[5], out int goalTarget);
                        int.TryParse(parts[6], out int amountCompleted);

                        var checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, bonusPoints);
                        checklistGoal.SetCurrentCount(amountCompleted);
                        lineGoal = checklistGoal;
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Incomplete ChecklistGoal data: {line}");
                    }
                    break;

                default:
                    Console.WriteLine($"Warning: Unknown goal type '{goalType}'");
                    continue;
            }

            if (lineGoal != null)
            {
                _goals.Add(lineGoal);
            }
        }
        Console.WriteLine($"Successfully loaded {_goals.Count} goals from save file.");
    }

    private void SaveGoalsToSave(string saveFile)
    {
        // Save Goals to file
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    // My Methods
    public bool GetUserConfirmation()
    {
        string response;
        while (true)
        {
            Console.WriteLine("Are you sure? (Y/N)");
            Console.Write("  > ");
            response = Console.ReadLine().Trim().ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter 'Y' or 'N'.");
            }
        }
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
    public void ShowLoadingBar(int seconds, int updateDelay = 100, bool isTimeDisplayed = false)
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
            Thread.Sleep(updateDelay);
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