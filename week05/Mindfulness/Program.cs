// Exceeded Requirements with the following improvements:
// 1. Added multiple guided breathing techniques that are automatically selected based on the duration specified by the user.
// 2. Added animated progress bars and enhanced spinner animations beyond the basic countdown requirement.(This combined the countdown and spinner methods in Activity.cs)
// 3. Added a breathing session summary showing total inhale, exhale, hold, and activity time statistics. 
// 4. Expanded the reflection and listing activities with many additional prompts and questions to provide greater variety.
// 5. Added total program runtime tracking using Stopwatch and display of cumulative session time when exiting.

class Program
{
    static void Main(string[] args)
    {
        ActivityManager mindfulnessGame = new ActivityManager();
        mindfulnessGame.Start();
        
        Console.Write("Total Time in the Mindfulness Program : ");
        mindfulnessGame.DisplayTotalTime();
    }
}