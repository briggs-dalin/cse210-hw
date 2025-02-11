using System;

public abstract class Shape
{
private string _color; //Holds color
private string _name; //Holds name of the shape

public Shape(string color, string name)
{
    _color = color;//Color consturctor for the shapes
    _name = name; //Name Constructor for names
    
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

//getter for name
public string GetName()
{
    return _name;
}

//setter for name
public void SetName(string name)
{
    _name = name;
}



//Abstract method for the other shapes
public abstract double GetArea();

}