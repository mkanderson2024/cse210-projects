using System;

public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    //Methods
    public void Run()
    {
        Console.Clear();
        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.WriteLine("-----Breath in-----");
            ShowCountDown(5);
            Console.WriteLine("\n-----Breath out-----");
            ShowCountDown(5);
            Console.Clear();
            currentTime = DateTime.Now;
        }
    }
}