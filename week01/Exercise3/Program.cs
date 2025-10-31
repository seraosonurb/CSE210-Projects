using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerador = new Random();
        int magicNumber = randomGenerador.Next(1, 100);
        int guess = -1;
        int count = 0;
        string response = "";
        do
        {
            magicNumber = randomGenerador.Next(1, 100);
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    count += 1;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higer");
                    count += 1;
                }
                else
                {
                    count += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} times to guess.");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();

        } while (response != "no");
    }
}