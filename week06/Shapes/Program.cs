using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(5, "Red"));
        shapes.Add(new Rectangle(4, 6, "Blue"));
        shapes.Add(new Circle(3, "Green"));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetColor()} {shape.GetType().Name}: {shape.GetArea()}");
        }
    }
}