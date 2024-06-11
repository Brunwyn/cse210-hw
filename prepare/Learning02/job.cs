using System;

//      Responsibilities:
// Keeps track of the person's name and a list of their jobs.
//      Behaviors:
// Displays the resume, which shows the name first, followed by displaying each one of the jobs.


public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}