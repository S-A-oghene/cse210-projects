using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?" };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        GetListFromUser();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> itemsListed = new List<string>();
        Console.WriteLine("You have 10 seconds to list as many items as you can:");
        ShowCountDown(10);

        // Implement getting list from user

        Console.WriteLine("Number of items listed: " + itemsListed.Count); // Placeholder for actual counting
        return itemsListed;
    }
}