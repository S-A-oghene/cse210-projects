using System;

public abstract class Activity
{
    protected DateTime Date { get; private set; }
    protected int LengthInMinutes { get; private set; }
    protected DistanceUnit Unit { get; private set; }

    protected Activity(DateTime date, int lengthInMinutes, DistanceUnit unit)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
        Unit = unit;
    }

    public virtual double Distance()
    {
        return 0.0; // Default implementation, overridden by derived classes
    }

    public virtual double Speed()
    {
        return Distance() / LengthInMinutes * 60;
    }

    public virtual double Pace()
    {
        return LengthInMinutes / Distance();
    }

    public string GetSummary()
    {
        string distanceUnit = Unit == DistanceUnit.Kilometer ? "km" : "miles";
        string speedUnit = Unit == DistanceUnit.Kilometer ? "kph" : "mph";
        string paceUnit = Unit == DistanceUnit.Kilometer ? "min per km" : "min per mile";

        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name.ToUpper()} ({LengthInMinutes} min) - Distance {Distance():F1} {distanceUnit}, Speed {Speed():F1} {speedUnit}, Pace: {Pace():F1} {paceUnit}";
    }
}