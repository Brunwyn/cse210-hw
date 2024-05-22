using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string _userName = PromptUserName();
        int _userNumber = PromptUserNumber();
        int _numSquared = SquareNumber(_userNumber);
        DisplayResults(_userName, _numSquared);

    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program that demos functions!");
    } 

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Username? ");
        string _userNameInput = Console.ReadLine();
        return _userNameInput;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    //  Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int num)
    {
        int _square = num * num;
        return _square;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, your fav num squared is {square}.\n");
    }






}