// Class for journal entries
public class Entry
{
    public string Prompt { get; set; } // Property to store the prompt of the entry
    public string Response { get; set; } // Property to store the response of the entry
    public string Date { get; set; } // Property to store the date of the entry

    public Entry(string prompt, string response, string date) // Constructor to initialize an entry with prompt, response, and date
    {
        this.Prompt = prompt;
        this.Response = response;
        this.Date = date;
    }
}