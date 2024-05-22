using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // // create a list of words
        // List<string> words = new List<string>();

        // // add to list
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // // show size of list
        // Console.WriteLine(words.Count);

        // // for loop read
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // // acess by index
        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }


        // create a list of numbers
        List<int> numbers = new List<int>();

        // create default variables on first run
        string _starterUserInput = "";
        int _numToList = 0;

        // start infinit loop do while, with breakout condition if user enters zero
        do
        {
            try
            {
                Console.WriteLine("Give a number you want put into a list (0 = quit and print list):");
                _starterUserInput = Console.ReadLine();
                _numToList = int.Parse(_starterUserInput);
            }
            catch
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            // add to list conditionals
            if (_numToList != 0)
            {
                // info message
                Console.WriteLine($"given {_numToList}, adding to the numbers list\n");
                // add to list
                numbers.Add(_numToList);
            }
            else
            {
                // quit message
                Console.WriteLine($"{_numToList} given, quiting and printing results\n");

                // for loop read
                Console.WriteLine("\nYou entered these Intigers");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }

                // sum
                int _sumOfList = 0; //initialize sum at 0
                // do math using for each
                foreach (int num in numbers)
                {
                    _sumOfList += num;
                }
                // print result
                Console.WriteLine($"Sum of all numbers in list is {_sumOfList}\n");

                // average
                double _average = ((float)_sumOfList) / numbers.Count;
                // print average
                Console.WriteLine($"Average of the list is {_average}\n");

                // largest number
                int _topDog = 0;

                foreach (int num in numbers)
                {
                    if (num > _topDog)
                    {
                        // if num in list is larger than _topDog repalce topdog
                        _topDog = num;
                    }
                }
                // print top dog
                Console.WriteLine($"top dog or biggest number is {_topDog}\n");
            }

        }while  (_numToList != 0);
    }
}