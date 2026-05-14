    // A code template for the class: Job.
    // Responsibility: Keeps track of the company, job title, start year, and end year.
    // Behavior: Displays the job information in the format "Job Title (Company) StartYear-EndYear"

    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = -1;
        public int _endYear = -1;

        // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
    