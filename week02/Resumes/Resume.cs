using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Prior Jobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}