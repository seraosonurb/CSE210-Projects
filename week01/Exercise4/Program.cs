using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // variables and list that need to be defined before looop
        int userNumber = -1;
        int total = 0;
        float average = 0;
        int largest = 0;
        int smallestPositive = 0;
        List<int> numbers = new List<int>();

        // while loop that keeps asking numbers and adding them to the list
        while (userNumber != 0)
        {
            Console.Write("Enter a number(type 0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                break;
            }

        }
        
        // for loop that counts and sums the numbers in numbers list
        foreach (int number in numbers)
        {
            total = number + total;
        }
        Console.WriteLine($"The sum is: {total}");

        // for loop that takes the total and divides by the amount of numbers in the list
        foreach (int number in numbers)
        {
            float amount = numbers.Count;
            average = total / amount;
        }
        Console.WriteLine($"The average is {average}");

        // for loop to find the largest number in the list
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is {largest}.");

        // for loop to find the smallest positive number
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                smallestPositive = number;
                if (number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        Console.WriteLine($"The samallest positive number is {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);    
        }
        
    }
}