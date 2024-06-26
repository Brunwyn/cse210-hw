using System;

class Program
{
    static void Main(string[] args)
    {
        // test of the formatted print multiple seperation characters
        // not quite the same as the python but close, if could use newer C# it would be closer
            //will try using a class next time or for the final
            // hav an above sentance, below sentance, and a few presets
        int num_repeats = 25;
        string what_to_repeat = "-";
        string repeatedChar = new string(what_to_repeat[0], num_repeats);
        // insert the repeating character var
        Console.WriteLine($"\n{repeatedChar}\nHello Develop03 World!\n{repeatedChar}\n");


        // actual asignment starts here - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // example of using the program to memorize a preset reference
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life (three).");

        // conditional while loop
        // After each round of hiding words, the program checks if all words are hidden using the IsCompletelyHidden method.
        // If all words are hidden, the main loop will end, and the program will terminate.
        // not looping one last time
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            // Hide 3 new words at a time, unfortunately the end is left with two that then don't get hidden. seems to be the program skipps the last loop
            scripture.HideRandomWords(3);
        }

        // wow you finished / did it message
        Console.WriteLine("\nThanks for playing! Try again some time?");
        // add a way to loop or play again
        // add a way to select from a list of scriptures
    }
}