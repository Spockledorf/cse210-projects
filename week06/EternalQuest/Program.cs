// Exceeded Requirements:
// 1. Added a customizable save file system. The user can specify different save file names rather than being restricted to a single hardcoded save file.
// 2. Added save-file safety features including confirmation prompts before loading, saving, or clearing data to help prevent accidental loss of progress.
// 3. Added robust save-file validation and error handling when loading data. Invalid scores, malformed goal data, and unknown goal types are detected and handled gracefully instead of crashing the program.
// 4. Added a custom animated loading bar that is displayed during various program operations to provide visual feedback and improve the user experience.
// 5. Added a player leveling system. The user's score is converted into a level that increases as more points are earned, providing an additional gamification element beyond the core requirements.
// 6. Improved user input validation with reusable methods that ensure numerical selections remain within valid ranges and prevent invalid menu choices.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        GoalManager game = new GoalManager();
        
        Console.Write("Starting ");
        game.ShowLoadingBar(1,30);
        game.Start();

        
    }
}