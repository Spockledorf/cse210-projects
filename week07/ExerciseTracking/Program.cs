using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(3, "Nov", 2022, 30, 3.0),
            new RunningActivity(4, "Nov", 2022, 30, 4.8),
            new BikingActivity(5, "Nov", 2022, 45, 15.0),
            new BikingActivity(6, "Nov", 2022, 60, 22.4),
            new SwimmingActivity(7, "Nov", 2022, 30, 40),
            new SwimmingActivity(8, "Nov", 2022, 40, 45)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}