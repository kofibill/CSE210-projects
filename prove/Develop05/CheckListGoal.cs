using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus, int amountCompleted) :base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        //return  amountCompleted == target
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("What is the short description of the goal? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that number of times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string GetDetailsString()
    {
        //similar to the simplegoal
    }

}