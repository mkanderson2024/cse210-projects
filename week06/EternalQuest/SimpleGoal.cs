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

    public override void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true; //Change this to what is needed
    }
    public override string GetStringRepresentation()
    {
        return "Addstring"; //Add string representation
    }
}