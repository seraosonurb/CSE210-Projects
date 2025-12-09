public abstract class Activity
{
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _date;
    protected int _length;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();

}