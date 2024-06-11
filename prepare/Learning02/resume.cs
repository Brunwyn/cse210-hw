using System;

//      Responsibilities:
// Keeps track of the company, job title, start year, and end year.
//      Behaviors:
// Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}