using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        if (laps < 0)
        {
            throw new ArgumentException("Number of laps must be non-negative.", nameof(laps));
        }

        if (minutes <= 0)
        
        {
            throw new ArgumentException("Duration in minutes must be greater than zero.",nameof(minutes));
        
        }

        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance > 0 ? distance / (minutes / 60.0) : 0;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return distance > 0 ? minutes / distance : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}