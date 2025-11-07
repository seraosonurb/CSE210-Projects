
public class Entry
{
    public string _entryText;
    public string _date;
    public string _promptText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}:");
        Console.Write($"{_entryText}");
        Console.WriteLine("\n");
    }
}

    
