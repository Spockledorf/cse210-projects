    // A code template for the class: Resume.
    // Responsibility: Keeps track of the person's name and a list of their jobs.
    // Behavior: Displays the resume, which shows the name first, followed by displaying each one of the jobs.

    public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs = new List<Job>();

        // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
        public Resume()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
             job.Display();   
            }
        }
    }
    