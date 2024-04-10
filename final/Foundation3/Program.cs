using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St.", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St.", "Toronto", "ON", "Canada");

        // Create events
        Lecture lecture = new Lecture("Lecture Title", "Lecture Description", DateTime.Now, new TimeSpan(18, 0, 0), address1, "Speaker Name", 100);
        Reception reception = new Reception("Reception Title", "Reception Description", DateTime.Now, new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Gathering Title", "Gathering Description", DateTime.Now, new TimeSpan(18, 0, 0), address1, "Sunny, 70°F");

        // Display event information
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(gathering.GetShortDescription());
    }
}