using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // example of formatted print to console
        int num_repeats = 20;
        string what_to_repeat = "--";
        string repeatedChar = "";
        for (int i = 0; i < num_repeats; i++)
        {
            repeatedChar += what_to_repeat;
        }

        Console.WriteLine($"\n{repeatedChar}\nHello Sandbox World!\n{repeatedChar}\n");


        

        // Get a string, Strings (a sequence of characters, including letters, numbers, or symbols)
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        // example of print a variable
        Console.Write($"Your favorite color is {color}.");

        // Get an int, Integers (whole numbers, positive and negative)


        // Get a float, Floating point numbers (numbers that use decimals)


        //  Get a double, Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places


        // Get a bool, Boolean variables (true or false)


        // example of simple if statement        
        Console.Write("X is 10");
        Console.Write("X is 5");
        int X = 10;
        int Y = 5;
        
        if (X>Y)
        {
            Console.WriteLine("X is greater // example of if satement");
        }

        // example of if else statement


        // example of if else elsee
    }
}