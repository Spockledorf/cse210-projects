using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager game = new ActivityManager();
        Activity myActivity = new Activity("Name", "Description", 30);
        game.DisplayTotalTime();

        myActivity.ShowProgressBar(10, 10, true);

        game.DisplayTotalTime();

        myActivity.ShowProgressBar(10, 10, false);
        game.DisplayTotalTime();
    }
}