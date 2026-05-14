using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        Resume myResume = new Resume();
        myResume._name = "Addyson Prose";

        Job job1 = new Job();
        job1._company = "MichaelSoft";
        job1._jobTitle = "Programmer";
        job1._startYear = 2015;
        job1._endYear = 2022;
        // Console.WriteLine($"Company: {job1._company}");
        // job1.Display();
        myResume._jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "Goggle";
        job2._jobTitle = "Lead Data Analyst";
        job2._startYear = 2022;
        job2._endYear = 2025;
        // Console.WriteLine($"Start Date: {job2._startYear}");
        // job2.Display();
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[1]._endYear);
        myResume.Display();
    }
}