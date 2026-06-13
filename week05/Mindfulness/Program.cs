using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager game = new ActivityManager();
        Activity myActivity = new Activity("Name", "Description", 30);
        game.DisplayTotalTime();

        game.Start();
        // myActivity.ShowProgressBar(10, 10, true);
        // myActivity.ShowProgressBar(10, 10, false);
        Console.Write("Totel Time : ");
        game.DisplayTotalTime();
    }
}