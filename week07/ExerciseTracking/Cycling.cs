public class Cycling: Activity
{
    public Cycling(string date, int length, double speed): base(date, length)
    {
        _date = date;
        _length = length;
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Ceiling(_speed * _length);
    }
    public override double GetSpeed()
    {
        return Math.Ceiling(GetDistance() / _length * 60);
    }
    public override double GetPace()
    {
        return Math.Ceiling(60 / _speed);
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType()} ({_length} min) - Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}