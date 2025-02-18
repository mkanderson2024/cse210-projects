using System;

public class SwimmingActivity : Activity
{
    //Member Variables
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    private int _laps;
    public SwimmingActivity(string date, int time, decimal distance, decimal speed, decimal pace, int laps) : base(date, time)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
        _laps = laps;
    }
    public override decimal GetDistance()
    {
        _distance = _laps * 50.0m / 1000.0m * 0.62m;
        return _distance;
    }
    public override decimal GetSpeed()
    {
        _speed = _distance / _time * 60;
        return _speed;
    }
    public override decimal GetPace()
    {
        _pace = 60 / _speed;
        return _pace;
    }

    public override void GetSummary()
    {
        decimal d = Math.Round(_distance, 1, MidpointRounding.ToEven);
        decimal p = Math.Round(_pace, 1, MidpointRounding.ToEven);
        decimal s = Math.Round(_speed, 1, MidpointRounding.ToEven);
        Console.WriteLine($"{_date} Swimming ({_time} min) - Distance {d} miles, Speed {_speed} mph, Pace: {p} min per mile.");
    }
}