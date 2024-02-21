using System;

public class Activity
{
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min)";
    }
}