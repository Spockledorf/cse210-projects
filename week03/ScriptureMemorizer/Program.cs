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
        int difficultySetting;
        bool isPunctuationHidden;

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
                    Console.WriteLine(myScripture.GetDisplayText());

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
                string userInputBook;
                int userInputChapter;
                int userInputVerse;
                int userInputVerseEnd;
                string userInputVerseText;


                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Book: ");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    userInputBook = userInput;
                    Console.Clear();
                    Console.WriteLine($"Is {userInputBook} correct? ('Enter' to proceed, any text to change)");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    if (userInput.ToLower() == "")
                    {
                        break;
                    }
                } while (true);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Chapter: ");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    // Bad input friendly
                    if (int.TryParse(userInput, out userInputChapter))
                    {
                        Console.Clear();
                        Console.WriteLine($"Is chapter {userInputChapter} correct? ('Enter' to proceed, any text to change)");
                        Console.Write(" > ");
                        userInput = Console.ReadLine().Trim();
                        if (userInput.ToLower() == "")
                        {
                            break;
                        }
                    }
                } while (true);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Verse Number: ");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    // Bad input friendly
                    if (int.TryParse(userInput, out userInputVerse))
                    {
                        Console.Clear();
                        Console.WriteLine($"Is verse {userInputVerse} correct? ('Enter' to proceed, any text to change)");
                        Console.Write(" > ");
                        userInput = Console.ReadLine().Trim();
                        if (userInput.ToLower() == "")
                        {
                            break;
                        }
                    }
                } while (true);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter End Verse Number: (Or '0' if only one verse)");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    // Bad input friendly
                    if (int.TryParse(userInput, out userInputVerseEnd))
                    {
                        Console.Clear();
                        Console.WriteLine($"Is verse {userInputVerseEnd} correct? ('Enter' to proceed, any text to change)");
                        Console.Write(" > ");
                        userInput = Console.ReadLine().Trim();
                        if (userInput.ToLower() == "")
                        {
                            break;
                        }
                    }
                } while (true);

                Reference userReference = new Reference(userInputBook, userInputChapter, userInputVerse, userInputVerseEnd);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Verse Text: ");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    userInputVerseText = userInput;
                    Console.Clear();
                    Console.WriteLine($"Is this verse text correct? ('Enter' to proceed, any text to change)");
                    Console.WriteLine(" --- ");
                    Console.WriteLine($"{userInputVerseText}");
                    Console.WriteLine(" --- ");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    if (userInput.ToLower() == "")
                    {
                        break;
                    }
                } while (true);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose difficulty setting:  (Default: 3, must be int between 1 and 10 inclusive)");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    int.TryParse(userInput, out difficultySetting); // Bad input friendly
                    if (difficultySetting >= 1 && difficultySetting <= 10)
                    {
                        break;
                    }

                } while (true);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose punctuation setting:  (Default: No. Yes / No, determines whether or not to hide punctuation.)");
                    Console.Write(" > ");
                    userInput = Console.ReadLine().Trim();
                    bool.TryParse(userInput, out isPunctuationHidden); // Bad input friendly
                    if (isPunctuationHidden == true || isPunctuationHidden == false)
                    {
                        break;
                    }

                } while (true);

                Scripture userScripture = new Scripture(userReference, userInputVerseText);
                userScripture.AdjustSettings(difficultySetting, isPunctuationHidden);

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(userScripture.GetDisplayText());

                    if (userScripture.IsCompletelyHidden())
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

                    userScripture.HideRandomWords(userScripture.GetDifficulty());
                }

            }
            else if (selectedOption == "Quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

        } while (true);
    }
}