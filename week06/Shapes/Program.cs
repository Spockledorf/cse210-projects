using System;

class Program
{
    static void Main(string[] args)
    {
        // List of shapes 
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 8));
        shapes.Add(new Rectangle("Red", 5, 10));
        shapes.Add(new Circle("Purple", 4.75));
        shapes.Add(new Square("Crimson", 7));
        shapes.Add(new Circle("Yellow", 10));
        
        Console.WriteLine(" --- Areas ---");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Type: {shape.GetType()}");
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea()} sq. u.");
        }
    }
}