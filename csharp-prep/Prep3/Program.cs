using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("What is the magic number? ");
        // string magicNum = Console.ReadLine();
        // int magicNumInt = int.Parse(magicNum);

        Random randomGenerator = new Random();
        int magicNumInt = randomGenerator.Next(1, 100);

        // Console.Write($"{magicNumInt}");

        bool correctGuess = false;

        while (!correctGuess)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            int numberGuess = int.Parse(input);

            if (numberGuess < magicNumInt)
            {
                Console.WriteLine("Higher");
            }

            else if (numberGuess > magicNumInt)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                correctGuess = true;
            }
        }
    }
}