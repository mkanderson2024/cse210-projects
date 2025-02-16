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
        int points = int.Parse(_points);
        Console.WriteLine("You've earned points!");
        GoalManager score = new GoalManager();
        score.SetScore(points);
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