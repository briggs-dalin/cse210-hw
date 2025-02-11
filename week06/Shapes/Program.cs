using System;

class Program
{
    static void Main(string[] args)
    {
    
    //List to hold shapes.
    List<Shape> shapes = new List<Shape>();

    //Square
    Square s1 = new Square("Red", "square", 5);
    shapes.Add(s1);


    //Rectangle
    Rectangle r2 = new Rectangle("Blue", "Rectangle", 4, 6);
    shapes.Add(r2);

    //Circle
    Circle c3 = new Circle("Green", "Circle", 7);
    shapes.Add(c3);

    //Loop for the shapes to list color and areas
    foreach (Shape s in shapes)
    {
        string color = s.GetColor();

        string name = s.GetName();

        double area = s.GetArea();

        Console.WriteLine($"The {color} {name} has an area of {area}!");
    }
    }
}