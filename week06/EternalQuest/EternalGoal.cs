using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void CreateChildGoal()
    {
        base.CreateChildGoal();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        return base.SaveGoal();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override int CalculateAGP()
    {
        return 0;
    }
}