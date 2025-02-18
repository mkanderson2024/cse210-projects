using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        RunningActivity r1 = new RunningActivity("03 Nov 2022", 30, 3.0m, 0, 0);
        CyclingActivity c1 = new CyclingActivity("04 Nov 2022", 40, 4.0m, 0, 0);
        SwimmingActivity s1 = new SwimmingActivity("05 Nov 2022", 50, 0, 0, 0, 10);

        activities.Add(r1);
        activities.Add(c1);
        activities.Add(s1);

        foreach (Activity a in activities)
        {
            a.GetDistance();
            a.GetSpeed();
            a.GetPace();
            a.GetSummary();
        }

    }
}