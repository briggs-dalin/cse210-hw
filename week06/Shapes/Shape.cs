using System;

public abstract class Shape
{
private string _color; //Holds color

public Shape(string color)
{
    _color = color;//Color consturctor for the shapes
}

//Getter for color
public string GetColor()
{
    return _color;
}

//Setter for color
public void SetColor(string color)
{
    _color = color;
}

//Abstract method for the other shapes
public abstract double GetArea();

}