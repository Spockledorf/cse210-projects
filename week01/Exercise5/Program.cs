using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Welcome to the program!
        Please enter your name: Brother Burton
        Please enter your favorite number: 42
        Brother Burton, the square of your number is 1764
        
        Functions:
        DisplayWelcome - Displays the message, "Welcome to the Program!"
        PromptUserName - Asks for and returns the user's name (as a string)
        PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        DisplayResult - Accepts the user's name and the squared number and displays them.
        */
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquare = SquareNumber(userNumber);
        DisplayResult(userName, userSquare);
    }
}