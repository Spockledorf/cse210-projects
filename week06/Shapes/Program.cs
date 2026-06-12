using System;

class Program
{
    static void Main(string[] args)
    {
        // List of shapes 
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 8);
        Rectangle rectangle1 = new Rectangle("Red", 5, 10);
        Circle circle1 = new Circle("Purple", 4.75);
        Square square2 = new Square("Crimson", 7);
        Circle circle2 = new Circle("Yellow", 10);
        
        Console.WriteLine(" --- Areas ---");
        Console.WriteLine($"square1 | Color: {square1.GetColor()} | Area: {square1.GetArea()} sq. u.");
        Console.WriteLine($"square2 | Color: {square2.GetColor()} | Area: {square2.GetArea()} sq. u.");
        Console.WriteLine($"rectangle1 | Color: {rectangle1.GetColor()} | Area: {rectangle1.GetArea()} sq. u.");
        Console.WriteLine($"circle1 | Color: {circle1.GetColor()} | Area: {circle1.GetArea()} sq. u.");
        Console.WriteLine($"circle2 | Color: {circle2.GetColor()} | Area: {circle2.GetArea()} sq. u.");
    }
}