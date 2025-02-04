using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    //Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //Getters
    public string GetHomeworkList()
    {   //Although we can use $"Section: {_textbookSection}. Problems: {_problems}" to write the string we can also use as discovered in the last assignment
        return "Section:" + _textbookSection + ". Problems:" + _problems;
    }
}