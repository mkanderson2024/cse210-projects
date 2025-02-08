using System;

public class ListiningActivity : Activity
{
    //Member Attributes
    private int _count;
    List<string> _prompts = new List<string>{"Who are the poeple that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?","List the days in the week when you took time to just have quiet time."};
    //Constructor
    public ListiningActivity(string activityName, string description) : base(activityName, description)
    {

    }
    //Methods
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public void GetListFromUser()
    {
        // List<string>
    }
}