using System;

public class ListingActivity : Activity
{
    //Member Attributes
    private int _count;
    List<string> _prompts = new List<string>{"Who are the poeple that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?","List the days in the week when you took time to just have quiet time and felt God's Presence."};
    //Constructor
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {

    }
    //Methods
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random prompts = new Random();
        int number = prompts.Next(_prompts.Count);
        string prompt = _prompts[number];
        Console.WriteLine("Ponder the following prompt: ");
        Console.WriteLine($"\n---{prompt}---");
        Console.Write("\nWhen ready, press enter to continue");
        Console.ReadLine();
    }

    public void GetListFromUser()
    {
        // List<string>
    }
}