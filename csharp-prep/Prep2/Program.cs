using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // determine a letter grade: A >= 90, B >= 80, C >= 70, D >= 60, F < 60

        // setup default variables that will be used later
        string _letterGrade = "Null";

        // ask for grade persentage
        Console.WriteLine("What is your grade percentage? (given as an intiger of 0 - 100):");
        // grab input as string change to int
        string _userGivenGrade = Console.ReadLine();
        int _gradeNumber = int.Parse(_userGivenGrade);

        // if-elif-else conditionals to choose proper write statement, later change conditionals to set letter variable and print in a single formatted print
        if (_gradeNumber >= 90)
        {
            _letterGrade = "A";
        }
        else if (_gradeNumber >= 80)
        {
            _letterGrade = "B";
        }
        else if (_gradeNumber >= 70)
        {
            _letterGrade = "C";
        }
        else if (_gradeNumber >= 60)
        {
            _letterGrade = "D";
        }
        else if (_gradeNumber < 60)
        {
            _letterGrade = "F";
        }
        else
        {
            // learn how to do actualy error handling
            Console.WriteLine("The math is not mathing, and the brain is not braining");
        }


        // later print statement
        Console.WriteLine($"\nYour Letter Grade is: {_letterGrade}");


        // seperate if statement to determine if user passed the course; if pass = congradulate, if fail = encourage for next time
        if (_gradeNumber >= 70)
        {
            Console.WriteLine("\nCongradulations you passed!\n");
        }
        else
        {
            Console.WriteLine("\nBetter luck next time\n");
        }










    }
}