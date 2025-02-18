using System;

public class Running : Exercise
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {

        _name = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return base.CalculateSpeed();
    }

    public override double CalculatePace()
    {
        return base.CalculatePace();
    }
}