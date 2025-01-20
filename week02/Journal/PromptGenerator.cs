using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is something you wish you would have done differently today?",
        "If there is someone who stands out to you, who is it?",
        "What is something spiritual that happened to you today?",
        "What is something you did today you enjoyed doing?",
        "If there is someone you wish you could talk to today, who would it be?"
    };
    public string GetRandomPrompt()
    {
        Random _randomNumber = new Random();
        int _promptNumber = _randomNumber.Next(0, 5);
        string _prompt = _prompts[_promptNumber];
        return _prompt;
    }
}