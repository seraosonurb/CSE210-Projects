using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        if (grade >= 90)
        {
            Console.Write("A");
        }
        else if (grade >= 80)
        {
            Console.Write("B");
        }
        else if (grade >= 70)
        {
            Console.Write("C");
        }
        else if (grade >= 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }
    }   
}