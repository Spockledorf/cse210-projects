using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(3, "Nov", 2022, 30, 3.0),
            new BikingActivity(4, "Nov", 2022, 45, 15.0),
            new SwimmingActivity(5, "Nov", 2022, 40, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}