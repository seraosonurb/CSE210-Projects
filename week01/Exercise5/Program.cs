using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // function to dsiplay message
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // function to ask and return user's name (as string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // function to ask for fav number 
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // function to get an integer as parameter and return the squared number
        static int SquareNumber (int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

        DisplayMessage();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);

        DisplayResult(userName, squaredNumber);
    }

}