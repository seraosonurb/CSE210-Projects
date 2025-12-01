using System.Drawing;

public class Square : IShape
{
    public Square(float side, string color) : base(color)
    {
        _side = side;
    }
    private float _side;
    public override double GetArea()
    {
        return _side * _side;
    }
}