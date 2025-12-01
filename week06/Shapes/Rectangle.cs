public class Rectangle : IShape
{
    public Rectangle(double length, double width, string color) : base(color)
    {
        _lenght = length;
        _width = width;
    }
    private double _lenght;
    private double _width;
    public override double GetArea()
    {
        return _lenght * _width;
    }

}