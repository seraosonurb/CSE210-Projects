public class EternalGoal : IGoal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you earned {_points}!");
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"( ) {_shortName} ({_description})";
    }
        public override string GetDetailsString()
    {
        return GetType() + ":" + _shortName + "," + _description + "," + _points.ToString();
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