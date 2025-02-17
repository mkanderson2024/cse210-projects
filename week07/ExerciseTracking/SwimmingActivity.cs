using System;

public class SwimmingActivity : Activity
{
    //Member Variables
    private float _distance;
    private float _speed;
    private float _pace;
    public SwimmingActivity(string date, int time, float distance, float speed, float pace) : base(date, time)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public override double GetDistance()
    {
        return 0;
    }
    public override double GetSpeed(int time)
    {
        return 0;
    }
    public override double GetPace(int speed)
    {
        return 0;
    }

    public override void GetSummary()
    {

    }
}