using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        double total = 0;
        int number;
        do
        {
            
            Console.Write("Enter Number: ");
            
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
                total = total + number;
            }
        } while (number != 0);

    double average = total / numbers.Count;
    int maximum = numbers.Max();
    
    // Display Results
    Console.WriteLine($"Sum: {total}");
    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Largest number: {maximum}");
    }
}