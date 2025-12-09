public class Running: Activity
{
    public Running(string date, int length, double distance): base(date, length)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return Math.Ceiling(_distance / _length * 60);
    }
    public override double GetPace()
    {
        return Math.Ceiling(_length / _distance);
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType()} ({_length} min) - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles";
    }
}