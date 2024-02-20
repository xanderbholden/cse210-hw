using System;

public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed:F1} mph";
    }
}