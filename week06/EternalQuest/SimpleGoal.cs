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
    public override List<string> ReturnList()
    {
        List<string> temp = new List<string>();
        temp.Add(_shortName);
        temp.Add(_description);
        temp.Add(_points);
        return temp;
    }
}