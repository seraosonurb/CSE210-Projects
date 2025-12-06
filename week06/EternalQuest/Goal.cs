public abstract class IGoal
{
    public IGoal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    protected string _shortName;
    protected string _description;
    protected int _points;

    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract string GetDetailsString();
    public abstract string GetName();
    public abstract int GetPoints();


}