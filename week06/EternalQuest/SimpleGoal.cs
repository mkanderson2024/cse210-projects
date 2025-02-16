using System;

public class SimpleGoal : Goal
{
    //Member Variables
    private bool _isComplete;

    //Constructors

    public SimpleGoal(string goalName, string description, string points, bool completion) : base(goalName, description, points)
    {
        _isComplete = completion;
    }

    //Methods

    public override void RecordEvent()
    {
        Console.WriteLine("Found a simple goal");

    }
    public override bool IsComplete()
    {
        return true; //Change this to what is needed
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points}";
    }
}