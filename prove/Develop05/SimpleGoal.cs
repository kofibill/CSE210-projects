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

        // How are you adding the point of the goal to the total point.
        // Checking if each goal is completed or not and then you add the point.

        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
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

    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {name} ({description})";
        }
        else
        {
            return $"[ ] {name} ({description})";
        }
    }
}