using System;

public class Goal
{
    //Member Variables

    private string _shortName = "";
    private string _description = "";
    private string _points = "";

    //Constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true; //Change this when its needed
    }
    public string GetDetailsString()
    {
        return "addstring"; //Add this
    }
    public string GetStringRepresentation()
    {
        return "addrepresentation"; //Add this
    }
}