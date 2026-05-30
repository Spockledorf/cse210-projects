using System;

class Program
{
    static void Main(string[] args)
    {
        // Define myScripture Components
        Reference myReference = new Reference("Mosiah", 23, 21, 24);
        string myText = "Nevertheless the Lord seeth fit to chasten his people; yea, he trieth their patience and their faith. Nevertheless- whosoever putteth his trust in him the same shall be lifted up at the last day. Yea, and thus it was with this people. For behold, I will show unto you that they were brought into bondage, and none could deliver them but the Lord their God, yea, even the God of Abraham and Isaac and of Jacob. And it came to pass that he did deliver them, and he did show forth his mighty power unto them, and great were their rejoicings.";

        // Define Menu. 
        // Note that it's 0-indexed, user input will be converted later.
        List<string> menuOptions = new List<string>{
            "Use Pre-Loaded Verse",
            "Use User-Entered Verse",
            "Quit" // Keep quit last, defines loop logic
        };

        string userInput;
        int userInt;
        string selectedOption;
        
        do
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine("Please select one of the following choices:");


            // Display Menu options
            int count = 0;
            foreach (string option in menuOptions)
            {
                count++;
                Console.WriteLine($"{count}. {menuOptions[count - 1]}");
            }

            // User Menu Select
            Console.Write(" > ");
            userInput = Console.ReadLine().Trim();
            // userChoiceInt = int.Parse(userInput);
            int.TryParse(userInput, out userInt); // Bad input friendly


            // Basic Error handling for user choosing numbers outside menuOptions range
            if (!(userInt >= 1 && userInt <= menuOptions.Count))
            {
                continue;
            }
            selectedOption = menuOptions[userInt - 1];

            if (selectedOption == "Use Pre-Loaded Verse")
            {
                // Define Scripture
                Scripture myScripture = new Scripture(myReference, myText);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(myScripture.GetDisplayText(myScripture.IsPunctuationHidden()));

                    if (myScripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("All words hidden!");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue or type 'quit'.");

                    userInput = Console.ReadLine().Trim().ToLower();

                    if (userInput == "quit")
                    {
                        break;
                    }

                    myScripture.HideRandomWords(myScripture.GetDifficulty());
                }

            }
            else if (selectedOption == "Use User-Entered Verse")
            {
                
            }
            else if (selectedOption == "Quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

        } while (true);
    }
}