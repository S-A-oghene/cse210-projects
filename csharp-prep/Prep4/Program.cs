using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a number (or 0 to stop): ");
        int input = int.Parse(Console.ReadLine());

        while (input != 0)
        {
            numbers.Add(input);

            Console.Write("Enter a number (or 0 to stop): ");
            input = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numbers entered: " + string.Join(", ", numbers));

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + max);

    }
}