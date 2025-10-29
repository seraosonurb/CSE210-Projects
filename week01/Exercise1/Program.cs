using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        Console.Write($"How old are you {first_name}? ");
        string number = Console.ReadLine();
        int age = int.Parse(number);
        int years = 100 - age;
        Console.Write($"{first_name}, it will take you {years} years to be 100 years old!");
    }
}