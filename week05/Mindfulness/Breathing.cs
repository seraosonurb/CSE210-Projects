// Will display breathing instructions, a countdown to breat in and breath out and a end message
using System.ComponentModel;

public class Breathing: Activity
{
    public Breathing()
    {
        _activityName = "Breathing activity";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    
    }
    public void Run()
    {               
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your session?");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(10);
        Console.WriteLine("");
        int remainingTime = _activityDuration;
        while (remainingTime >= 4)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            remainingTime -=4;
            if (remainingTime >= 6)
            {
                Console.Write("\nNow breath out...");
                ShowCountDown(6);
                remainingTime -= 6;
            }
            else
            {
                remainingTime = 0;
            }
        }
        DisplayEndingMessage();
        Thread.Sleep(4000);
        Console.Clear();


    }

}