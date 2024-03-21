using System;

public class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        do
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

        } while (!scripture.AllWordsHidden());
        
        Console.WriteLine("All words in the scripture are now hidden. Program ended.");
    }
}
