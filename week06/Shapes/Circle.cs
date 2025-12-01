public class Circle : IShape
{
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    private double _radius;
    public override double GetArea()
    {
        return Math.Pow(_radius, 2) * Math.PI;
    }
}