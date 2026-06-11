using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Benny", "Long Division");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Michael Stone", "Fractions", "2.65", "23-35");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Tobin Wrath", "Medical", "A Comprehensive History of Surgical Implements in the United States");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}