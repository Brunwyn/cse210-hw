using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        int num_repeats = 25;
        string what_to_repeat = "-";
        string repeatedChar = new string(what_to_repeat[0], num_repeats);

        Console.WriteLine($"\n{repeatedChar}\nHello Learning03 World!\n{repeatedChar}\n");
    }
}