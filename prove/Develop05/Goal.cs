class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // Implement recording event for a goal
        Console.WriteLine($"Event recorded for {_shortName}");
    }

    public virtual bool IsComplete()
    {
        // Implement checking if goal is complete
        return false;
    }

    public virtual string GetDetailsString()
    {
        // Implement getting details string for a goal
        return $"{_shortName}: {_description}, {_points} points";
    }

    public virtual string GetStringRepresentation()
    {
        // Implement getting string representation of a goal
        return $"Goal: {_shortName},{_description},{_points}";
    }

    public string GetName()
    {
        return _shortName;
    }
}