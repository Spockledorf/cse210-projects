using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine("Welcome to the Number guessing game!");

            int userGuess;
            do
            {
                // Console.WriteLine($"The magic number: {number}");

                Console.WriteLine("What is your guess?");
                Console.Write(" > ");
                userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);
                if (userGuess == number)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Higher");
                }

            } while (userGuess != number);
            Console.WriteLine("Play again? (yes/no)");
            Console.Write(" > ");
            userInput = Console.ReadLine();

        } while (userInput == "yes");

    }
}