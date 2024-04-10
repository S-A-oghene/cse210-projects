using System;

public class RunningActivity : Activity
{
    private double DistanceIn { get; set; } // Can be kilometers or miles depending on Unit

    public RunningActivity(DateTime date, int lengthInMinutes, double distance, DistanceUnit unit) : base(date, lengthInMinutes, unit)
    {
        DistanceIn = distance;
    }

    public override double Distance()
    {
        return DistanceIn;
    }
}