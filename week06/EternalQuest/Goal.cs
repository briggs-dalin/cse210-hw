
using System;
public class Goal
{
    protected string _name;
    protected string _description;

    protected int _goalPoints;

    protected bool _status;

    public Goal()
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;

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
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);

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