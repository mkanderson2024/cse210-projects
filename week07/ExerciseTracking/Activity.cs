using System;

public abstract class Activity
{
    //Member Variables
    protected string _date;
    protected int _time;
    //Constructor
    public Activity(string date, int time)
    {

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
    public abstract double GetDistance();
    public abstract double GetSpeed(int time);
    public abstract double GetPace(int speed);

    public abstract void GetSummary();
}