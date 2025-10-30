using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            int total = grade % 10;
            if (total >= 7)
            {
                sign = "+";
                letter = "B";
            }
            else if (total <= 3)
            {
                sign = "-";
                letter = "B";
            }
            else
            {
                sign = "";
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            int total = grade % 10;
            if (total >= 7)
            {
                sign = "+";
                letter = "C";
            }
            else if (total <= 3)
            {
                sign = "-";
                letter = "C";
            }
            else
            {
                sign = "";
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            int total = grade % 10;
            if (total >= 7)
            {
                sign = "+";
                letter = "D";
            }
            else if (total <= 3)
            {
                sign = "-";
                letter = "D";
            }
            else
            {
                sign = "";
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.Write($"Congratulations! Your grade is {sign}{letter}, you passed!");
        }
        else
        {
            Console.Write($"Your grade is {sign}{letter}. Better luck next time.");
        }
    }   
}