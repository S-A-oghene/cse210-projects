class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        // No completion for eternal goals
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}