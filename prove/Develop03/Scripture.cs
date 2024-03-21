using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private List<Word> hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.words = new List<Word>();
        this.hiddenWords = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"Scripture: {reference.Book} {reference.Chapter}:{reference.VerseStart}-{reference.VerseEnd}");
        foreach (Word word in words)
        {
            if (hiddenWords.Contains(word))
            {
                Console.Write("***** ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        
        int wordsToHide = Math.Min(random.Next(1, words.Count - hiddenWords.Count + 1), words.Count - hiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            if (index < words.Count && !hiddenWords.Contains(words[index]))
            {
                hiddenWords.Add(words[index]);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWords.Count == words.Count;
    }
}
