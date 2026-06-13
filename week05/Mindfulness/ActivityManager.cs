public class ActivityManager
{
    private bool _running = true;

    public ActivityManager()
    {
        // Construct
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
        // TODO: instantiate and start your breathing activity
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
        // Display elapsed time!
    }
}