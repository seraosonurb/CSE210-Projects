public class Comment
{
    public string _name;
    public string _comment;
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_name} says:");
        Console.WriteLine($"'{_comment}'\n");
    }
}