using System;

class Program
{
    static void Main(string[] args)
    {
        // // This is some sample code to practice some basics.
        // int x;
        // x = 7;
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Console.Write("X = ");
        // Console.WriteLine(x);
        // Console.Write("X + 3 = ");
        // Console.WriteLine(x+3);

        // int y = 5;

        // if (x > y)
        // {
        //     Console.Write("X is greater than Y as ");
        //     Console.Write(x);
        //     Console.Write(" > ");
        //     Console.Write(y);
        // }
        // if (x < y)
        // {
        //     Console.Write("X is less than Y as ");
        //     Console.Write(x);
        //     Console.Write(" < ");
        //     Console.Write(y);
        // }
        Console.Write("What is your First Name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your Last Name? ");
        string lastName = Console.ReadLine();
        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}