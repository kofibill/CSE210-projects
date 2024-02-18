using Sytem;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points):base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("What is the short description of the goal? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine(); 
    }

    public override GetDetailsString()
    {
        return $"[ ] {name} ({description})";
    }
}