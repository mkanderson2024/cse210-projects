using System;

public class EternalGoal : Goal
{
    //Constructors

    public EternalGoal(string goalName, string description, string points) : base(goalName, description, points)
    {

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
    public override bool IsComplete()
    {
        return true; //Change as needed
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}