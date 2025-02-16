using System;

public class ChecklistGoal : Goal
{
    //Member Variables
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    //Constructors
    public ChecklistGoal(string goalName, string description, string points, int bonus, int completed, int target) : base(goalName, description, points) //Add inherited strings from Goal
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    //Methods

    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        Console.WriteLine($"\nYou've earned {points} points!");
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            GoalManager score = new GoalManager();
            int addScore = score.SetScore(points);
            addScore += _bonus;
            return addScore;
        }
        else
        {
            GoalManager score = new GoalManager();
            int addScore = score.SetScore(points);
            return addScore;
        }
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_shortName}: {_description} | {_points} | {_bonus} | Completed -- {_amountCompleted}/{_target}.";
        }
        else
        {
            return $"[ ] {_shortName}: {_description} | {_points} | {_bonus} | Completed -- {_amountCompleted}/{_target}.";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }
}