using System;

public class SimpleGoal : Goal
{
        //Default constructor with default values for Simple goals
    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 50;
        _status = false;
    }
    

    //Constructor with parameters for better customization
    public SimpleGoal(string name, string description, int points, bool status) 
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }

    //Overide to make a child goal class
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }
    //Recording the event
    public override void RecordEvent()
    {
        if (_status == false) 
        {
            _status = true;
        }
        else
        //If goal is already done
        {
            Console.WriteLine("You already completed this goal.");
        }
    } 
    

    
    

    public override bool IsComplete()
    {
        if(_status == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void ListGoal()
    {
        string statusSymbol = "";

        bool status = IsComplete();

        if (status == true)
        {
            statusSymbol = "X";
        }
        else
        {
            statusSymbol = " ";
        }
        Console.WriteLine($"[{statusSymbol}] {_name} ({_description})");
    }

    public override int CalculateAGP()
    {
        bool status = IsComplete();
        int aGP = 0;

        //if goal is complete, return points, otherwise no points
        if (status == true)
        {
            aGP = _points;
        }
        else
        {
            aGP = 0;
        }
        return aGP;
    }

    //saving goals in a specific format
    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description}{_points},{IsComplete().ToString()}";
        return line;
    }

}