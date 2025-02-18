using System;

public abstract class Activity
{
    //Member Variables
    protected string _date;
    protected int _time;
    //Constructor
    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }
    //Methods
    public string GetDate(string date)
    {
        _date = date;
        return _date;
    }
    public int GetTime(int time)
    {
        _time = time;
        return _time;
    }
    //Abstract Methods
    public abstract decimal GetDistance();
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();

    public abstract void GetSummary();
}