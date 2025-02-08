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
        Console.WriteLine(duration);

        while (currentTime < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breath in");
            ShowCountDown(5);
            Console.Clear();
            Console.WriteLine("Breath out");
            ShowCountDown(5);
            currentTime = DateTime.Now;
        }
    }
}