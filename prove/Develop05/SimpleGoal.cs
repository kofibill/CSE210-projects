using Sytem;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) :base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {

    }

    public override string GetStringRepresentation()
    {

    }
}