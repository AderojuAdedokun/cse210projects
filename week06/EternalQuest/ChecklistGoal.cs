public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Add this constructor for loading from file
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        // TODO: Implement
        return 0;
    }

    public override bool IsComplete()
    {
        // TODO: Implement
        return false;
    }

    public override string GetDetailsString()
    {
        // TODO: Implement
        return "";
    }

    public override string GetStringRepresentation()
    {
        // TODO: Implement
        return "";
    }
}