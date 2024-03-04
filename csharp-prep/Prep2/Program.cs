using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int userGradeValue = int.Parse(userGrade);

        if (userGradeValue >= 90)
        {
            // Console.WriteLine("Your letter grade is 'A' ");
            letter = "A";
        }

        else if (userGradeValue < 90 && userGradeValue >= 80)
        {
            // Console.WriteLine("Your letter grade is 'B' ");
            letter = "B";
        }

        else if (userGradeValue < 80 && userGradeValue >= 70)
        {
            // Console.WriteLine("Your letter grade is 'C' ");
            letter = "C";
        }

        else if (userGradeValue < 70 && userGradeValue >= 60)
        {
            // Console.WriteLine("Your letter grade is 'D' ");
            letter = "D";
        }

        else
        {
            // Console.WriteLine("Your letter grade is 'F' ");
            letter = "F";
        }

        Console.WriteLine("");
        Console.WriteLine($"{letter}");

        if (!(userGradeValue < 70))
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }

        else
        {
            Console.WriteLine("Your efforts have not met the desired outcome this time, but that's okay. It's an opportunity to learn and grow. With a little more effort and perseverance, you can achieve your goals. Remember, success requires persistence. Keep going, and you'll get there!");
        }

    }


}