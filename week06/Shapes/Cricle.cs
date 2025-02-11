using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, string name, double radius) : base(color, name)
    {
        _radius = radius;
    }

    //Area for circle. Had to google how they wanted the Pi format
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}