public abstract class IShape
{
    public IShape(string color)
    {
        _color = color;
    }
    private string _color;
    public virtual string GetColor()
    {
        return _color;
    }
    public virtual void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}