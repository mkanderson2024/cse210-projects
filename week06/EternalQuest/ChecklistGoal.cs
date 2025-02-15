using System;

public class ChecklistGoal
{
    //Member Variables
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    //Constructors
    public ChecklistGoal(int target, int bonus) //Add inherited strings from Goal
    {

    }

    //Methods

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true; //Change as needed
    }
    public string GetDetailsString()
    {
        return "Addstring"; //Add string for details
    }
    public string GetStringRepresentation()
    {
        return ""; //Add string for representation
    }
}