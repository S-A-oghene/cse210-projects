class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        LoadGoals();
        DisplayPlayerInfo();
        ListGoalNames();
        ListGoalDetails();
        CreateGoal();
        RecordEvent();
        SaveGoals();
    }

    private void LoadGoals()
    {
        // Implement loading goals from a file
        Console.WriteLine("Loading goals...");
    }

    private void DisplayPlayerInfo()
    {
        // Implement displaying player information
        Console.WriteLine("Player Info:");
        Console.WriteLine($"Score: {_score}");
    }

    private void ListGoalNames()
    {
        // Implement listing goal names
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    private void ListGoalDetails()
    {
        // Implement listing goal details
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        // Implement creating a new goal
        Console.WriteLine("Creating a new goal...");
    }

    private void RecordEvent()
    {
        // Implement recording an event for a goal
        Console.WriteLine("Recording an event...");
    }

    private void SaveGoals()
    {
        // Implement saving goals to a file
        Console.WriteLine("Saving goals...");
    }
}