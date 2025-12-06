public class ChecklistGoal : IGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
            Console.WriteLine($"Congratulations you earned {_points} points!");
        }
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations you earned {_bonus} bonus for completing the goal!");   
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetStringRepresentation()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_shortName} ({_description}) --- Current completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {_shortName} ({_description}) --- Current completed: {_amountCompleted}/{_target}";
    }
    public override string GetDetailsString()
    {
        return GetType() + ":" + _shortName + "," + _description + "," + _points.ToString() + "," + _bonus + "," + _target + "," + _amountCompleted;
    }
    public override string GetName()
    {
        return _shortName;
    }
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _bonus;
        }
        return _points;
    }
}