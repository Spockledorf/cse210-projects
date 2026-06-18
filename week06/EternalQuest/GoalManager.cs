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
        "Set Save File",    // 6
        "Clear Save",       // 7
        "Quit"              // 8
    ];
    private readonly List<string> _goalTypes = [
        "Simple Goal",
        "Eternal Goal",
        "Checklist Goal"
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
                    ShowLoadingBar(2, 50);
                    Console.Clear();
                    CreateGoal();

                    break;
                case 2:
                    // List Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(2, 50);
                    Console.Clear();
                    ListGoalDetails();
                    Console.WriteLine();
                    DisplayPlayerInfo();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    break;
                case 3:
                    // Save Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    // ShowLoadingBar(2, 50);
                    Console.Clear();
                    Console.WriteLine("⚠ Warning: Save file will be overwritten!");
                    if (GetUserConfirmation())
                    {
                        SaveGoalsToSave(_saveFile);
                    }
                    else
                    {
                        Console.WriteLine("Operation Cancelled.");
                    }
                    ShowLoadingBar(2, 50);
                    break;
                case 4:
                    // Load Goals
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    // ShowLoadingBar(2, 50);
                    Console.Clear();
                    Console.WriteLine("⚠ Warning: Current loaded goals will be overwritten by save file!");
                    if (GetUserConfirmation())
                    {
                        LoadGoalsFromSave(_saveFile);
                    }
                    else
                    {
                        Console.WriteLine("Operation Cancelled.");
                    }
                    ShowLoadingBar(2, 50);
                    break;
                case 5:
                    // Record Event
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(2, 50);
                    Console.Clear();
                    ListGoalNames();
                    Console.WriteLine("What goal did you accomplish?");
                    int goalNum = GetUserIntSelect(_goals.Count);
                    _goals[goalNum].RecordEvent();
                    Console.WriteLine();
                    _score += _goals[goalNum]._points;
                    Console.WriteLine($"You now have {_score} points!");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    break;
                case 6:
                    // Set Save File
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(2, 50);
                    Console.Clear();
                    Console.Write("Specify save file: ");
                    string userSaveFile = Console.ReadLine().Trim();
                    _saveFile = userSaveFile;
                    Console.WriteLine($"Save file set as: '{_saveFile}'");
                    ShowLoadingBar(2, 50);
                    break;
                case 7:
                    // Clear Goals from list
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(2, 50);
                    Console.Clear();
                    Console.WriteLine("⚠ Warning: Current loaded goals will be erased!");
                    if (GetUserConfirmation())
                    {
                        _goals.Clear();
                        Console.WriteLine("Goals erased.");
                    }
                    else
                    {
                        Console.WriteLine("Operation Cancelled.");
                    }
                    ShowLoadingBar(2, 50);
                    break;
                case 8:
                    // Quit
                    Console.WriteLine($"Selected: '{_menuOptions[option - 1]}'");
                    ShowLoadingBar(2, 50);
                    _running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowLoadingBar(2, 50);
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
            Console.WriteLine($"  {count}. {_menuOptions[count - 1]}");
        }
        // Console.Write("Select a choice from the menu: ");
    }

    private void DisplayPlayerInfo()
    {
        // display stats
        Console.WriteLine($"Current Points: {_score}");
        Console.WriteLine($"Number of Goals: {_goals.Count}");
    }
    private void ListGoalNames()
    {
        // List Goal Names
        Console.Clear();
        Console.WriteLine("My Goals:");

        // Display Menu options
        int count = 0;
        foreach (Goal goal in _goals)
        {
            count++;
            Console.WriteLine($"  {count}. {_goals[count - 1].GetNameString()}");
        }
    }

    private void ListGoalDetails()
    {
        // List Goal Details
        Console.WriteLine("My Goals:");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        // Create Goal
        Console.WriteLine("Select Goal Type to create: ");
        int count = 0;
        foreach (string goalType in _goalTypes)
        {
            count++;
            Console.WriteLine($"  {count}. {goalType}");
        }
        Console.WriteLine("Enter 0 to cancel.");
        int option = GetUserIntSelect(_goalTypes.Count, 0);
        switch (option)
        {
            case 0:
                Console.WriteLine("Goal creation cancelled.");
                ShowLoadingBar(2, 50);
                break;
            case 1:
                {
                    // Simple
                    Console.WriteLine("Simple Goal:");
                    Console.WriteLine("Enter Goal Short Name: (e.g. Read the Bible)");
                    Console.Write("  > ");
                    string goalShortName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Goal Description: (e.g. Read the bible for 10min a day)");
                    Console.Write("  > ");
                    string goalDescription = Console.ReadLine().Trim();

                    int lowerBound = -99999;
                    int upperBound = 99999;
                    int goalPoints = GetUserIntSelect(upperBound, lowerBound);

                    SimpleGoal simpleGoal = new SimpleGoal(goalShortName, goalDescription, goalPoints);
                    _goals.Add(simpleGoal);
                    break;
                }
            case 2:
                {
                    // Eternal
                    Console.WriteLine("Eternal Goal:");
                    Console.WriteLine("Enter Goal Short Name: (e.g. Pray)");
                    Console.Write("  > ");
                    string goalShortName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Goal Description: (e.g. Daily prayer)");
                    Console.Write("  > ");
                    string goalDescription = Console.ReadLine().Trim();

                    int lowerBound = -99999;
                    int upperBound = 99999;
                    int goalPoints = GetUserIntSelect(upperBound, lowerBound);

                    EternalGoal eternalGoal = new EternalGoal(goalShortName, goalDescription, goalPoints);
                    _goals.Add(eternalGoal);
                    break;
                }
            case 3:
                {
                    // Checklist
                    Console.WriteLine("Checklist Goal:");
                    Console.WriteLine("Enter Goal Short Name: (e.g. Exercise)");
                    Console.Write("  > ");
                    string goalShortName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Goal Description: (e.g. Work out)");
                    Console.Write("  > ");
                    string goalDescription = Console.ReadLine().Trim();

                    int lowerBound = -99999;
                    int upperBound = 99999;
                    int goalPoints = GetUserIntSelect(upperBound, lowerBound);

                    Console.WriteLine("Enter how many times this goal must be completed: (e.g. 10)");
                    int goalTarget = GetUserIntSelect(upperBound, 1);

                    Console.WriteLine("Enter bonus points awarded on completion: (e.g. 500)");
                    int bonusPoints = GetUserIntSelect(upperBound, 0);

                    ChecklistGoal checklistGoal = new ChecklistGoal(goalShortName, goalDescription, goalPoints, goalTarget, bonusPoints);
                    _goals.Add(checklistGoal);
                    break;
                }
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
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

        if (lines.Length == 0)
        {
            Console.WriteLine("Save file is empty.");
            return;
        }

        // First line = score
        if (!int.TryParse(lines[0], out _score))
        {
            Console.WriteLine($"Warning: Invalid score value '{lines[0]}'");
            _score = 0;
        }

        // Start at line 1, line 0 is score
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');

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

            Goal lineGoal = null;

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
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            // First line = score
            outputFile.WriteLine(_score);

            // Remaining lines are goals
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Successfully saved {_goals.Count} goals to save file.");
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
            ShowLoadingBar(1, 10);
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