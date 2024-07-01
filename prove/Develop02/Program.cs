using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Do you want a random prompt? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    journal.AddEntry();
                }
                else
                {
                    Console.Write("Enter a prompt: ");
                    string prompt = Console.ReadLine();

                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Enter the date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();

                    journal.AddEntry(prompt, response, date);
                }
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine($"Journal saved to {filename}");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine($"Journal loaded from {filename}");
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}