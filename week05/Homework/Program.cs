using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Mr. Clown", "Funny Business");
        string mySummary = myAssignment.GetSummary();

        Console.WriteLine(mySummary);
    }
}