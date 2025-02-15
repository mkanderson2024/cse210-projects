using System;

public class ChecklistGoal : Goal
{
    //Member Variables
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    //Constructors
    public ChecklistGoal(string goalName, string description, string points, int target, int bonus) : base(goalName, description, points) //Add inherited strings from Goal
    {
        _target = target;
        _bonus = bonus;
    }

    //Methods

    public override void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true; //Change as needed
    }
    public string GetDetailsString()
    {
        return $"{_target}, {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return ""; //Add string for representation
    }
}