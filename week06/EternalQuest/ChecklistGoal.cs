using System;

public class ChecklistGoal : Goal
{
    //Member Variables
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    //Constructors
    public ChecklistGoal(string goalName, string description, string points, int bonus, int target) : base(goalName, description, points) //Add inherited strings from Goal
    {
        _target = target;
        _bonus = bonus;
    }

    //Methods

    public override void RecordEvent()
    {
        Console.WriteLine("Found ChecklistGoal");
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} | {_points} | {_bonus} | {_target} times. Completed -- {_amountCompleted} times.";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target}";
    }
}