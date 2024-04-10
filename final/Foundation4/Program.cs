using System;

class Program
{
    static void Main(string[] args)
    {
        // Choose the desired distance unit (Kilometer or Mile)
        DistanceUnit unit = DistanceUnit.Kilometer; // Change to Mile if preferred

        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity(DateTime.Now, 30, 3.0, unit));
        activities.Add(new CyclingActivity(DateTime.Now, 60, 20.0, unit));
        activities.Add(new SwimmingActivity(DateTime.Now, 45, 40, unit));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}