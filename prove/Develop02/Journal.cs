using System;

public class Journal
{
    public List<JournalEntry> Entries { get; set; }
    public List<string> Prompts { get; set; }
    private Random random;

    public Journal()
    {
        Entries = new List<JournalEntry>();
        Prompts = new List<string>
        {
            "Who did I interact with today that stood out to me?",
            "What stood out today?",
            "How did your morning start?",
            "Where and How have I seen God today?",
            "How has this week been?",
            "What was something fun or exciting that happened?",
        };
        random = new Random();
    }

    public void AddEntry(string prompt = null, string response = null, string date = null)
    {
        if (prompt == null)
        {
            Console.Write("Are you sure you want a random prompt? (y/n): ");
            string promptChoice = Console.ReadLine().ToLower();
            if (promptChoice == "n")
            {
                Console.WriteLine("\n you chose to write your own prompt, or failed to type a lowercase y by itselft.");
                Console.Write("Enter a prompt: ");
                prompt = Console.ReadLine();
            }
            else
            {
                prompt = GetRandomPrompt();
                Console.WriteLine(prompt);
            }
        }

        if (response == null)
        {
            Console.Write("Enter your response: ");
            response = Console.ReadLine();
        }

        if (date == null)
        {
            date = DateTime.Now.ToString("yyyy-MM-dd");
        }

        JournalEntry entry = new JournalEntry(prompt, response, date);
        Entries.Add(entry);
    }

    private string GetRandomPrompt()
    {
        return Prompts[random.Next(Prompts.Count)];
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"\nDate: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        
        try
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    file.WriteLine(entry.Date);
                    file.WriteLine(entry.Prompt);
                    file.WriteLine(entry.Response);
                    file.WriteLine();
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
        
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using (StreamReader file = new StreamReader(filename))
        {
            string date, prompt, response;
            while ((date = file.ReadLine()) != null)
            {
                prompt = file.ReadLine();
                response = file.ReadLine();
                file.ReadLine(); // Skip the empty line
                AddEntry(prompt, response, date);
            }
        }
    }
}