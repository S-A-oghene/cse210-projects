using System;
using System.Collections.Generic;
using System.IO;

// Dear Instructor, Kindly pardon the numerous comments here. They are meant to help me better understand every libe of code within the program. Thank you.

// Main program class
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        int choice;

        do
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    myJournal.AddEntry();
                    break;
                case 2:
                    myJournal.DisplayEntries();
                    break;
                case 3:
                    myJournal.SaveToFile("journal.txt");
                    break;
                case 4:
                    myJournal.LoadFromFile("journal.txt");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        } while (choice != 5);

        Console.WriteLine("Exiting program...");
    }
}