public class WritingAssignment: Assignment
{
    public WritingAssignment(string name, string topic, string title): base(name, topic)
    {
        _title = title;
    }
    private string _title;
    public string GetWritingIinformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}