using System;

public class ReflectingActivity : Activity
{
    //Member Attributes
    List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};
    List<string> _questions = new List<string>{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
};
    //Constructor
    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {

    }
    //Methods
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.WriteLine("Begin in:");
        ShowCountDown(5);
        int duration = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            GetRandomQuestion();
            ShowSpinner(7);
        }
        Console.WriteLine("You have completed the Refleting Activity.");
    }

    public void GetReflectionPrmopt()
    {
        Random prompts = new Random();
        int number = prompts.Next(_prompts.Count);
        string prompt = _prompts[number];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n---{prompt}---");
        Console.Write("\nWhen ready, press enter to continue ");
        Console.ReadLine();
    }

    public string GetRandomQuestion()
    {
        Random questions = new Random();
        int number = questions.Next(_questions.Count);
        string question = _questions[number];
        return question;
    }
}