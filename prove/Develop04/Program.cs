using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Program!");

        // Create instances of activities
        Activity breathingActivity = new BreathingActivity();
        Activity reflectingActivity = new ReflectingActivity();
        Activity listingActivity = new ListingActivity();

        // Run activities
        breathingActivity.Run();
        reflectingActivity.Run();
        listingActivity.Run();

        Console.WriteLine("Program completed.");
    }
}