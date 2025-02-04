using System;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";
    //Setters
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    //Getters
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"Student: {_studentName}, topic: {_topic}";
    }
}