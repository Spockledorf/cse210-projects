using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _diameter = 0;
    public Circle(string color, double diameter) : base(color)
    {
         _diameter = diameter;
    }

    public override double GetArea()
    {
        // PI * r * r
        double radius = _diameter / 2;
        return ((float)Math.PI) * radius * radius;
    }
}