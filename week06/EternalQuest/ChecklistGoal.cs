using System;

public class ChecklistGoal : Goal
{
    private int _steps;
    private int _stepsCounter;

    private int _bonus;

    

    public ChecklistGoal(string name, string description, int points, int bonus, int steps, int stepsCounter)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _steps = steps;
        _stepsCounter = stepsCounter;

    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.WriteLine("How many times does this goal need to be completed for a bonus?");
        string stringChecklistSteps = Console.ReadLine();
        _steps = Convert.ToInt32(stringChecklistSteps);

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonusPoints = Console.ReadLine();
        _bonus = Convert.ToInt32(bonusPoints);

        _stepsCounter = 0;
    }

    public override bool IsComplete()
    {
        if (_stepsCounter >= _steps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RecordEvent()
    {
        _stepsCounter ++;
    }

    public override int CalculateAGP()
    {
        int points = 0;

        points = _stepsCounter * _points;

        bool status = IsComplete();

        if (status == true)
        {
            points += _bonus;
        }
        return points;
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
        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_stepsCounter}/{_steps}");
    }

    public override string SaveGoal()
    {
       string line = "";
       line = $"Checklist Goal: {_name}, {_description}, {_points.ToString()}, {_bonus.ToString()}, {_steps.ToString()}, {_stepsCounter.ToString()}";
       return line;
    }
}