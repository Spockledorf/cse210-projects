using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        GoalManager game = new GoalManager();
        
        Console.Write("Starting ");
        game.ShowLoadingBar(1,30);
        game.Start();

        
    }
}