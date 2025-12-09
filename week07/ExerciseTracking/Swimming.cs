public class Swimming: Activity
{
    public Swimming(string date, int length, int laps): base(date, length)
    {
        _date = date;
        _length = length;
        _laps = laps;
    }
    private int _laps;
    public override double GetDistance()
    {
        return Math.Ceiling(_laps * 50 / 1000 * 0.62);
    }
    public override double GetSpeed()
    {
        return Math.Ceiling(GetDistance() / _length * 60);
    }
    public override double GetPace()
    {
        return Math.Ceiling(GetSpeed() / 60);
    }

    public override string GetSummary()
    {
        return $"{_date} {GetType()} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";

    }
}