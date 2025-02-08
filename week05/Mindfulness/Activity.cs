using System;

public class Activity
{
    //Member Attributes
    private string _name;
    private string _description;
    private int _duration;

    //Constructor
    public Activity(string activityName, string description)
    {
        _name = activityName;
        _description = description;
    }

    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nYou have chosen the {_name} Activity.");
        Console.WriteLine($"\n This activity will help you relax by {_description}");
        Console.Write("\n How long would you like to do this activity in seconds? ");
        string timeResponce = Console.ReadLine();
        _duration = int.Parse(timeResponce);
    }
    public int GetTime()
    {
        return _duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
    }
    public void ShowSpinner(int seconds)
    {
        //Animation Perameters
        List<string> symbols = new List<string> { "|", "/", "——", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        //Animation Engine
        while (currentTime < stopTime)
        {
            Console.Write("");
            foreach (string symbol in symbols)
            {
                Console.Write("\b \b");
                Console.Write(symbol);
                Thread.Sleep(500);
                currentTime = DateTime.Now;
            }
        }
        Console.Clear();
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        List<int> numbers = new List<int> { 5, 4, 3, 2, 1 };

        while (currentTime < endTime)
        {
            foreach (int number in numbers)
            {
                Console.Write("");
                Console.Write("\b \b");
                Console.Write($"{number}");
                Thread.Sleep(1000);
                currentTime = DateTime.Now;
            }
        }
    }

}