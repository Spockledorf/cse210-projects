using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Construct
        // No unique member variables
    }

    public void Run()
    {
        DisplayStartingMessage();
        _duration = GetValidatedDuration();

        // Select breathing pattern based on duration from user        
        int inhale, hold1, exhale, hold2;
        if (_duration < 30)
        {
            (inhale, hold1, exhale, hold2) = (4, 0, 4, 0);
        }
        else if (_duration < 90)
        {
            (inhale, hold1, exhale, hold2) = (4, 0, 6, 0);
        }
        else if (_duration < 180)
        {
            (inhale, hold1, exhale, hold2) = (4, 4, 4, 4);
        }
        else if (_duration < 600)
        {
            (inhale, hold1, exhale, hold2) = (4, 7, 8, 0);
        }
        else
        {
            (inhale, hold1, exhale, hold2) = (6, 0, 6, 0);
        }

        int cycleLength = inhale + hold1 + exhale + hold2;
        int cycles = _duration / cycleLength; // Gets whole cycle count to avoid partial breaths.

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine($"Breathing pattern is {inhale}-{hold1}-{exhale}-{hold2}");
        ShowSpinner(3, false);
        
        // Get stopwatch, as time may be different than activity duration.
        var timer = Stopwatch.StartNew();

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Breathe in...      (Cycle {i + 1} of {cycles})");
            ShowProgressBar(inhale, inhale * 2, true, true);

            if (hold1 > 0)
            {
                Console.WriteLine($"Hold...     ");
                // ShowProgressBar(hold1, hold1 * 2, true, true);
                ShowSpinner(hold1, true);
            }

            Console.WriteLine("Breathe out...  ");
            ShowProgressBar(exhale, exhale * 2, false, true);
            
            if (hold2 > 0)
            {
                Console.WriteLine($"Hold...     ");
                // ShowProgressBar(hold2, hold2 * 2, true, true);
                ShowSpinner(hold2, true);
            }
        }

        // Display breathing metrics
        DisplayBreathingStats(inhale, hold1, exhale, hold2, cycles, timer.Elapsed.Minutes, timer.Elapsed.Seconds);
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();

        // End of unique activity
        DisplayEndingMessage();
    }
    private void DisplayBreathingStats(int inhale, int hold1, int exhale, int hold2, int cycles, int minutes, int seconds)
    {
        Console.WriteLine();
        Console.WriteLine($" --- Breathing Activity Summary ---");
        Console.WriteLine($"Time Inhaling: {inhale * cycles}s");
        Console.WriteLine($"Time Exhaling: {exhale * cycles}s");
        Console.WriteLine($"Time Holding Breath: {(hold1 * cycles) + (hold2 * cycles)}s");
        Console.WriteLine($"Total Time: {minutes:D2}m {seconds:D2}s");
        Console.WriteLine($" ----------------------------------");
        Console.WriteLine();

    }
}