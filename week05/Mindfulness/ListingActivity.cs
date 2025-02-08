using System;

//For added creativity, added an additional readback of each item the person writes and states that they are able to see good things in their lives that do matter.

public class ListingActivity : Activity
{
    //Member Attributes
    private int _count;
    List<string> _prompts = new List<string>{"Who are the poeple that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "List the days in the week when you took time to just have quiet time and felt God's presence."};
    List<string> _responces = new List<string>();
    //Constructor
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {

    }
    //Methods
    public void Run()
    {
        _count = 0;
        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _responces.Add(item);
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(3);
        GetListFromUser();
        ShowSpinner(3);
    }

    public void GetListingPrompt()
    {
        Random prompts = new Random();
        int number = prompts.Next(_prompts.Count);
        string prompt = _prompts[number];
        Console.WriteLine("List as many responces as you can to the following prompt: ");
        Console.WriteLine($"\n---{prompt}---");
        Console.Write("\nWhen ready, press enter to continue ");
        Console.ReadLine();
    }

    public void GetListFromUser()
    {
        Console.WriteLine("Remember these....");
        foreach (string entry in _responces)
        {
            Console.WriteLine($"{entry}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("....They mean good things happen in your life. And they do matter because you matter.");
    }
}