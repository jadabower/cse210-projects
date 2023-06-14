using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(4.0, "red");
        Rectangle rect = new Rectangle(2.0, 4.2, "blue");
        Circle cir = new Circle(3.14, "green");
        
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}