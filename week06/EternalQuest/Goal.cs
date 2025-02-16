using System;

public abstract class Goal
{
    //Member Variables

    protected string _shortName = "";
    protected string _description = "";
    protected string _points = "";

    //Constructors
    public Goal(string goalName, string description, string points)
    {
        _shortName = goalName;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    //Getters
    public string GetName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} | {_points} |";
    }

    public abstract string GetStringRepresentation();
}