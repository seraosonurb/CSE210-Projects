public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    private List<Comment> _comments = new List<Comment>();
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"'{_title}' from: {_author}: {_lenght} seconds");
        Console.WriteLine($"The video has {GetNumberOfComments()} comments.\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
}