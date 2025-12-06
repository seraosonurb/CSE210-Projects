public class SimpleGoal : IGoal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    { 
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        IsComplete();
        Console.WriteLine($"Congratulations you earned {_points} points!");

    }
    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
         return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";

    }
    public override bool IsComplete()
    {
        return _isComplete = true;
    }
    public override string GetDetailsString()
    {
        return GetType() + ":" + _shortName + "," + _description + "," + _points.ToString() + "," + _isComplete;
    }
    public override string GetName()
    {
        return _shortName;
    }
    public override int GetPoints()
    {
        return _points;
    }

}
