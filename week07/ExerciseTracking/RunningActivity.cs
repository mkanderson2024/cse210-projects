using System;

public class RunningActivity : Activity
{
    //Member Variables
    private float _distance;
    private float _speed;
    private float _pace;
    public RunningActivity(string date, int time, float distance, float speed, float pace) : base(date, time)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed(int time)
    {
        _speed = _distance / time * 60;
        return _speed;
    }
    public override double GetPace(int speed)
    {
        _pace = 60 / _speed;
        return _pace;
    }

    public override void GetSummary()
    {

    }
}