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
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise. \n\n*Note: Complete cycles of breathing will be determined based on what fits withing the user-defined duration. Actual activity time may be slightly shorter or longer than the input.", 0);
        breathingActivity.Run();
    }

    private void StartReflectingActivity()
    {
        List<string> prompts = 
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you faced a fear.",
            "Think of a time when you kept going even when you wanted to quit.",
            "Think of a time when you made a hard decision.",
            "Think of a time when you defended what you believed in.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you went out of your way for someone else.",
            "Think of a time when you made someone's day better.",
            "Think of a time when you sacrificed your time or comfort for another.",
            "Think of a time when you forgave someone who hurt you.",
            "Think of a time when you served without being asked.",
            "Think of a time when you failed and got back up.",
            "Think of a time when you learned something the hard way.",
            "Think of a time when you changed for the better.",
            "Think of a time when you adapted to an unexpected situation.",
            "Think of a time when you surprised yourself.",
            "Think of a time when you grew through a painful experience.",
            "Think of a time when you turned a weakness into a strength.",
            "Think of a time when you accomplished something you worked hard for.",
            "Think of a time when your efforts made a real difference.",
            "Think of a time when you finished something you started.",
            "Think of a time when your Faith in Christ carried you through hardship.",
            "Think of a time when you felt guided by the spirit.",
            "Think of a time when you lived the Gospel of Jesus Christ even when there was pressure to do otherwise.",
            "Think of a time when you trusted God even when things were uncertain."
        ];

        List<string> questions =
        [
            "Why was this experience meaningful to you?",
            "How did this experience affect the people around you?",
            "What made this moment stand out from everyday life?",
            "What would have been lost if this moment had never happened?",
            "What did you learn about yourself through this experience?",
            "What personal strengths did you discover or use?",
            "What surprised you about how you handled this situation?",
            "How did this experience change the way you see yourself?",
            "Who or what helped you along the way?",
            "What emotions did you experience during this time?",
            "How can you keep this experience in mind in the future?",
            "Have you ever done anything like this before?",
            "How might this experience prepare you for future challenges?",
            "What would you tell someone else who is facing a similar situation?",
            "How can you build on this strength going forward?"
        ];

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.", 0, prompts, questions);

        reflectingActivity.Run();
    }

    private void StartListingActivity()
    {
        List<string> prompts =
        [
            "Who are people that you appreciate?",
            "Who has supported you through a difficult time?",
            "Who are people you have helped this week?",
            "Who has made you laugh recently?",
            "Who are some of your personal heroes?",
            "Who has positively influenced who you are today?",
            "Who do you feel safe around?",

            "What are personal strengths of yours?",
            "What skills have you developed over the years?",
            "What challenges have you overcome?",
            "What are things you are proud of accomplishing?",
            "What habits have improved your life?",
            "What have you learned this past year?",

            "What simple pleasures bring you happiness?",
            "What places make you feel at peace?",
            "What memories make you smile?",
            "What foods do you enjoy?",
            "What hobbies or activities energize you?",
            "What books, movies, or music have impacted you?",
            "What things in nature do you find beautiful?",

            "When have you felt the Holy Ghost this month?",
            "What blessings have you received this week?",
            "What prayers have been answered in your life?",
            "What gospel principles have brought you peace?",
            "Who are people you have served recently?",
            "What scriptures or quotes have strengthened you?",

            "What modern conveniences are you grateful for?",
            "What opportunities are available to you?",
            "What things about your home do you appreciate?",
            "What freedoms do you enjoy?",
            "What about your health are you grateful for?",
            "What resources do you have access to?"
        ];

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized. ", 0, prompts);

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