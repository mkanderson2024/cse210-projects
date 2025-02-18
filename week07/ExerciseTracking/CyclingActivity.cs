using System;

public class CyclingActivity : Activity
{
    //Member Variables
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    public CyclingActivity(string date, int time, decimal distance, decimal speed, decimal pace) : base(date, time)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public override decimal GetDistance()
    {
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
        Console.WriteLine($"{_date} Cycling ({_time} min) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile.");
    }
}