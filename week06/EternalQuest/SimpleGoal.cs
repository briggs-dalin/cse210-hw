using System;

public class SimpleGoal : Goal
{


    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void CreateChildGoal()
    {
        base.CreateChildGoal();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void ListGoal()
    {
        base.ListGoal();
    }

    public override int CalculateAGP()
    {
        return 0;
    }

    public override string SaveGoal()
    {
        return base.SaveGoal();
    }

}