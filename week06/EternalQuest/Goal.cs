
using System;
public class Goal
{
    protected string _name;
    protected string _description;

    protected int _points;

    protected bool _status;

    public Goal()
    {
        _name = "Test Name";
        _description = "Test Description";
        _points = 50;
        _status = false;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    //Method to prompt user for goal details and create said goal
    protected void CreateBaseGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points for this goal? ");
        //Convert the int into a string
        string stringPoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringPoints);

        _status = false; //Goal starts out not complete

    }

    //Virtual method for saving goal details to be used for other goal classes
    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent()
    {

    }


    public virtual Boolean IsComplete()
    {
        return false;
    }

    public virtual void ListGoal()
    {

    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}