public class Listing: Activity
{
    public Listing()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many thins as you can in a certain area.";
    }
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month? ", "What are you doing in order to be a better disciple? ",
        "What makes you feel happy? ", "When have I helped someone this month? "
    };
    
    private bool timeOver = false;
    public void Run() 
    {
        DisplayStartingMessage();
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        
        Thread timer = new Thread(() =>
        {
            for (int t = _activityDuration; t > 0; t--)
            {
                Thread.Sleep(1000);
            }
            timeOver = true;
        });

        timer.Start();
        List<string> answers = GetListFromUser();

        _count = answers.Count();
        Console.WriteLine($"You listed {_count} items!\n");
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
    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        while (!timeOver)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            answers.Add(userInput);
            if(timeOver) break;
            if(string.IsNullOrEmpty(userInput)) continue;
        }
        return answers;
    }
}