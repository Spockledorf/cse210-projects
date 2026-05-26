// Menu CodeStub
// Define Menu. 
// Note that it's 0-indexed, user input will be converted later.
    List<string> menuOptions = [
        "New Verse",
        "Quit" // Keep quit last, defines loop logic
    ];

    string userInput;
    int userChoiceInt;
    string userChoiceText;

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

        if (userChoiceText == "New Verse")
        {

        }
        else if (userChoiceText == "Quit")
        {
            Console.WriteLine("Goodbye!");
            break;
        }

    } while (true);