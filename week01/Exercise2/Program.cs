using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that determines the letter grade for a course according to the following scale:
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60
        // If last digit >=7, add "+"
        // If last digit <3, add "-"
        // Excptions: A+, F+, or F-

        Console.Write("Enter Grade %: ");
        string userInput = Console.ReadLine();
        int gradePercentInt = int.Parse(userInput);
        int lastDigit = gradePercentInt % 10;
        string letterGrade;
        string message;
        // bool gradeIsPassing;

        if (gradePercentInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentInt >= 60)
        {
            letterGrade = "D";
        }
        else if (gradePercentInt < 60)
        {
            letterGrade = "F";
        }
        else
        {
            letterGrade = "Error";
        }

        if (gradePercentInt >= 70)
        {
            // gradeIsPassing = true;
            message = "Congratulations! You passed!";
        }
        else
        {
            // gradeIsPassing = false;
            message = "Womp womp. You did not achieve a passing grade.";
        }

        if (gradePercentInt > 60 && gradePercentInt < 97)
        {
            if (lastDigit >= 7)
            {
                letterGrade = letterGrade + "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade = letterGrade + "-";
            }
        }

        Console.WriteLine($"Percent Grade: {gradePercentInt}%");
        Console.WriteLine($"Letter Grade: {letterGrade}");
        Console.WriteLine(message);
    }
}