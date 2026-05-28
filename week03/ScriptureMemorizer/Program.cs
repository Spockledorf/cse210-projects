using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;

        // Define Scripture Components
        Reference myReference1 = new Reference("Mosiah", 23, 21, 24);
        string myText1 = "Nevertheless the Lord seeth fit to chasten his people; yea, he trieth their patience and their faith. Nevertheless- whosoever putteth his trust in him the same shall be lifted up at the last day. Yea, and thus it was with this people. For behold, I will show unto you that they were brought into bondage, and none could deliver them but the Lord their God, yea, even the God of Abraham and Isaac and of Jacob. And it came to pass that he did deliver them, and he did show forth his mighty power unto them, and great were their rejoicings.";

        // Define Scripture
        Scripture myScripture = new Scripture(myReference1, myText1);

        do
        {
            
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            
            if (myScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words hidden!");
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit'.");
            
            userInput = Console.ReadLine().Trim().ToLower();
            
            if (userInput == "quit")
            {
                break;
            }

            myScripture.HideRandomWords(3);
        } while (true);
    }
}