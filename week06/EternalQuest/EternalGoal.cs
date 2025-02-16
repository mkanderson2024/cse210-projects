using System;

public class EternalGoal : Goal
{
    //Constructors

    public EternalGoal(string goalName, string description, string points) : base(goalName, description, points)
    {

    }

    //Methods
    public override void RecordEvent(List<Goal> list, int input)
    {

    }
    public override bool IsComplete()
    {
        return true; //Change as needed
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}