public class Reflecting: Activity
{
    private List<string> _prompts = new List<string>
    {
        "What exactly am I feeling right now — and what’s the message behind this emotion?",
        "What could I do today to ease a weight I’ve been carrying alone?",
        "What was the most important decision I made today — and why did I choose that path?",
        "What did I do today that made me genuinely proud of myself?",
        "If I keep my current habits, where will I be two years from now?"
    };
    private List<string> _questions = new List<string>
    {
        "How did you feel when this experience was completed? ", "How did it impact your mood during the day? ",
        "Have you felt any negative emotion during this experience? ", "What can you learn from this experience? ", 
        "Was it something that needs to be avoided? Why? ", "How can your loved ones help you? ", "What was the best part of the experience? ",
        "What is something positive that you can draw from it? "
    };
    public Reflecting()
    {
        _activityName = "Reflecting Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    }
    private bool timeOver = false;
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions and they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.Clear();
        Thread timer = new Thread(() =>
        {
            for (int t = _activityDuration; t > 0; t--)
            {
                Thread.Sleep(1000);
            }
            timeOver = true;
        });

        timer.Start();
        while (!timeOver)
        {
            DisplayQuestions();
            if (!timeOver)
            {
                ShowSpinner(10);
                Console.WriteLine("");
            }
        
        }

        DisplayEndingMessage();
        Thread.Sleep(4000);
        Console.Clear();


    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count());
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_prompts.Count());
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}