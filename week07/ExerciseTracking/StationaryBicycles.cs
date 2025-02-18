using System;

public class StationaryBicycles : Exercise
{
    private double _speed;

    public StationaryBicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bicycles";
        _speed = speed;

    }

    public override double CalculateDistance()
    {
        return base.CalculateDistance();
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