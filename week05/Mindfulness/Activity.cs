public class Activity
{
    public Activity()
    {
      
    }
    private List<string> _animations = new List<string>();

    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.\n");
        Console.WriteLine(_activityDescription);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!\n");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_activityDuration} seconds of {_activityName}");
    }
    public void ShowSpinner(int seconds)
    {
        _animations.Add("|");
        _animations.Add("/");
        _animations.Add("-");
        _animations.Add("\\");
        _animations.Add("|");
        _animations.Add("/");
        _animations.Add("-");
        _animations.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string f = _animations[i];
            Console.Write(f);
            Thread.Sleep(1000);
            Console.Write("\b");
            i++; 
            if (i >= _animations.Count())
            {
                i = 0;
            }
            Console.Write("");
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}