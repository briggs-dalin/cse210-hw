using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;

    

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void CreateChildGoal()
    {
        base.CreateChildGoal();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override int CalculateAGP()
    {
        return 0;
    }

    public override void ListGoal()
    {
        base.ListGoal();
    }

    public override string SaveGoal()
    {
        return base.SaveGoal();
    }
}