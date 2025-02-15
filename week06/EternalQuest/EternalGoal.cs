using System;

public class EternalGoal : Goal
{
    //Constructors

    public EternalGoal(string goalName, string description, string points) : base(goalName, description, points)
    {

    }

    //Methods
    public override void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true; //Change as needed
    }
    public override string GetStringRepresentation()
    {
        return "Addstring"; //Add string representation
    }
}