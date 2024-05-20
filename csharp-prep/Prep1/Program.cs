using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        
        Console.Write("What is your favorite color? ");
        string _color = Console.ReadLine();
        Console.WriteLine($"Your favorite collor is {_color}\n\n");

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastname}, {firstname} {lastname}.");
    }
}