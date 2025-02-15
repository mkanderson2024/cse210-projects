using System;

public abstract class Goal
{
    //Member Variables

    private string _shortName = "";
    private string _description = "";
    private string _points = "";

    //Constructors
    public Goal(string goalName, string description, string points)
    {
        _shortName = goalName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return $"{_shortName}: {_description} | {_points} |";
    }

    public abstract string GetStringRepresentation();
}