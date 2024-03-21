using System;

public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string VerseStart { get; set; }
    public string VerseEnd { get; set; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        if (parts.Length >= 2)
        {
            Book = parts[0];
            string[] chapterVerse = parts[1].Split(':');
            if (chapterVerse.Length >= 2)
            {
                Chapter = chapterVerse[0];
                VerseStart = chapterVerse[1];
                VerseEnd = VerseStart; // Set VerseEnd to VerseStart if not a range
                if (VerseStart.Contains("-"))
                {
                    string[] verses = VerseStart.Split('-');
                    VerseStart = verses[0];
                    VerseEnd = verses[1];
                }
            }
        }
    }
}
