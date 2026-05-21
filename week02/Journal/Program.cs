// Exceeding requirements: Added "Stats" option showing entry count and total characters written.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Menu. 
        // Note that it's 0-indexed, user input will be converted later.
        List<string> menuOptions = [
            "Write",
            "Display",
            "Stats",
            "Load",
            "Save",
            "Quit" // Keep quit last, defines loop logic
        ];

        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        DateTime currentDateTime;

        string userInput;
        int userChoiceInt;
        string userChoiceText;
        int quitOption = menuOptions.Count;

        // Loop start
        do
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
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
            int.TryParse(userInput, out userChoiceInt); // Bad input friendly


            // Basic Error handling for user choosing numbers outside menuOptions range
            if (!(userChoiceInt >= 1 && userChoiceInt <= menuOptions.Count))
            {
                continue;
            }
            userChoiceText = menuOptions[userChoiceInt - 1];

            // Choice Declaration
            Console.WriteLine();
            Console.WriteLine($"You selected {userChoiceInt}. {userChoiceText}");
            Console.WriteLine();

            if (userChoiceText == "Write")
            {
                // Date logic
                currentDateTime = DateTime.Now;
                string dateText = currentDateTime.ToShortDateString();
                Console.WriteLine($"Date: {dateText}");

                // Prompt logic
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");

                // Response logic
                Console.Write(" > ");
                string response = Console.ReadLine();

                // Entry logic
                Entry newEntry = new Entry(dateText, prompt, response);
                myJournal.AddEntry(newEntry);

                // newEntry.Display();
            }
            else if (userChoiceText == "Display")
            {
                myJournal.DisplayAll();
            }
            else if (userChoiceText == "Load")
            {
                Console.WriteLine("What is the filename?");
                Console.Write(" > ");
                userInput = Console.ReadLine().Trim();
                myJournal.LoadFromFile(userInput);
            }
            else if (userChoiceText == "Stats")
            {
                int entryCount = myJournal._entries.Count();
                int charCount = myJournal.GetTotalCharCount();
                Console.WriteLine("  Stats:");
                Console.WriteLine($"   Entry Count: {entryCount}");
                Console.WriteLine($"   Total Characters Entered: {charCount}");

            }
            else if (userChoiceText == "Save")
            {
                Console.WriteLine("What is the filename?");
                Console.Write(" > ");
                userInput = Console.ReadLine().Trim();
                myJournal.SaveToFile(userInput);
            }
            else if (userChoiceText == "Quit")
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
                break;
            }

        } while (true);
    }
}