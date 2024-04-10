using System;

public class CyclingActivity : Activity
{
    private double SpeedIn { get; set; } // Can be kilometers per hour or miles per hour depending on Unit

    public CyclingActivity(DateTime date, int lengthInMinutes, double speed, DistanceUnit unit) : base(date, lengthInMinutes, unit)
    {
        SpeedIn = speed;
    }

    public override double Speed()
    {
        return SpeedIn;
    }
}