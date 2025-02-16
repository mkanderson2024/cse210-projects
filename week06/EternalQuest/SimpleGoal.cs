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

    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        Console.WriteLine($"\nYou've earned {points} points!");
        GoalManager score = new GoalManager();
        int addScore = score.SetScore(points);
        return addScore;

    }
    public override string GetDetailsString()
    {
        if (_isComplete == true)
            return $"[X] {_shortName}: {_description} | {_points} |";
        else
        {
            return $"[ ] {_shortName}: {_description} | {_points} |";
        }
    }
    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete; //Change this to what is needed
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points}";
    }
}