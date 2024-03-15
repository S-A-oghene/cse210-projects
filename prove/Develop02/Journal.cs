using System.Collections.Generic;
using System.IO;

// Class for managing the journal
public class Journal
{
    public List<Entry> Entries { get; set; } // List to store journal entries
    private readonly string separator = "~|~"; // Define the separator here

    public Journal() // Constructor to initialize the journal with an empty list of entries
    {
        this.Entries = new List<Entry>();
    }

    public void AddEntry() // Method to add a new entry to the journal
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?" // Add your own prompts here
        };

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        string prompt = prompts[promptIndex];

        Console.WriteLine(prompt); // Display a random prompt to the user
        string response = Console.ReadLine(); // Read user's response

        string date = DateTime.Now.ToString("yyyy-MM-dd"); // Get current date

        Entry newEntry = new Entry(prompt, response, date); // Create a new entry object
        Entries.Add(newEntry); // Add the new entry to the journal

        Console.WriteLine("Entry added successfully!"); // Inform user about successful addition of entry
    }

    public void DisplayEntries() // Method to display all entries in the journal
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("There are no entries in your journal."); // Inform if no entries are present
            return;
        }

        foreach (Entry entry in Entries) // Iterate through each entry and display its details
        {
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine("--------------------");
        }
    }

    public void SaveToFile(string filename) // Method to save journal entries to a file
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename)) // Open a StreamWriter to write to file
            {
                foreach (Entry entry in Entries) // Iterate through each entry and write its details to file
                {
                    writer.WriteLine($"{entry.Prompt}{separator}{entry.Response}{separator}{entry.Date}");
                }
            }
            Console.WriteLine("Journal saved successfully!"); // Inform user about successful save operation
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}"); // Handle and display error if saving fails
        }
    }

    public void LoadFromFile(string filename) // Method to load journal entries from a file
    {
        try
        {
            Entries.Clear(); // Clear existing entries before loading

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found."); // Inform if specified file is not found
                return;
            }

            using (StreamReader reader = new StreamReader(filename)) // Open a StreamReader to read from file
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Read each line from file until end is reached
                {
                    string[] parts = line.Split(new[] { separator }, StringSplitOptions.None);
                    if (parts.Length == 3)
                    {
                        Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                        Entries.Add(loadedEntry);
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}