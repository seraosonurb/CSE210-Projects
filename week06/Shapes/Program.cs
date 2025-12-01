using System;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>();
        shapes.Add(new Square(3, "Orange"));
        shapes.Add(new Rectangle(4, 5, "Purple"));
        shapes.Add(new Circle(20, "White"));
        foreach(IShape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The area is {area} and the color is {color}");
        }
    }

}