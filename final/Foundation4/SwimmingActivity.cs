using System;

public class SwimmingActivity : Activity
{
    private int NumberOfLaps { get; set; }

    public SwimmingActivity(DateTime date, int lengthInMinutes, int numberOfLaps, DistanceUnit unit) : base(date, lengthInMinutes, unit)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        return NumberOfLaps * 50.0 / (Unit == DistanceUnit.Kilometer ? 1000.0 : 1609.34);
    }
}