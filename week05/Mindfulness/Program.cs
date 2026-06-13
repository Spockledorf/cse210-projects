using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager game = new ActivityManager();
        game.Start();
        
        Console.Write("Totel Time : ");
        game.DisplayTotalTime();
    }
}