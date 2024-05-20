using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }



        // string response;

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");



        //The following code shows the syntax of a for loop that counts from 0 to 9. use of the ++ operator which increments the value in the variable by one.

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        //The code above is the most common way to see one of these loops, but you could put other values or statements in these spots, such as counting from 2 to 20 by two's:

        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }



        //C# contains a foreach loop that is similar to a standard for loop in Python. It is important to remember that the iterator variable must have its type defined, just like when declaring any other variable: Used For Lists

        //foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }



        //In addition, for this assignment you'll need to get a random number from the computer. In C#, this is done by creating an instance of the Random class, and then using it to get the next integer in a particular range.

        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);


        // default variables
        int _preMagicHigh = 0;
        int _preMagicLow = 0;
        string _highString = "";
        string _lowString = "";
        // used to keep track of guesses
        int _guess = 0;

        // get user defined range for random
        Console.WriteLine("You will give two intigers for a range of random numbers that will be picked from randomly to define the magic number.");

        // get low
        Console.WriteLine("\nGive the smallest number");
        _lowString = Console.ReadLine();
        _preMagicLow = int.Parse(_lowString);
        
        // get high
        Console.WriteLine("\nGive the highest number");
        _highString = Console.ReadLine();
        _preMagicHigh = int.Parse(_highString);

        //define magic number
        Random randomGenerator = new Random();
        int _magicNumber = randomGenerator.Next(_preMagicLow,_preMagicHigh);

        //inform user of number range
        Console.WriteLine($"\nThe magic number was chosen, it is somewhere between {_preMagicLow} and {_preMagicHigh}, good luck\n");

        do
        {
            Console.Write("What is your guess? ");
            _guess = int.Parse(Console.ReadLine());

            if (_magicNumber > _guess)
            {
                Console.WriteLine("Higher\n");
            }
            else if (_magicNumber < _guess)
            {
                Console.WriteLine("Lower\n");
            }
            else
            {
                Console.WriteLine("\n!!Sucess You WIN!!\n");
            }
        } while (_guess != _magicNumber);
    }
}