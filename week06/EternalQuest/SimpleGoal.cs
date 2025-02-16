using System;

public class SimpleGoal : Goal
{
    //Member Variables
    private bool _isComplete;

    //Constructors

    public SimpleGoal(string goalName, string description, string points) : base(goalName, description, points)
    {

    }

    //Methods

    public override void RecordEvent(List<Goal> list, int input)
    {

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