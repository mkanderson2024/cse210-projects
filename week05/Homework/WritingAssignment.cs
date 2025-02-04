using System;

public class WritingAssignment : Assignment
{
    private string _title = "";
    //Constructor

    //Because this calss inherits fromt he assignment class, the student name and topic must be in the constructor or it won't work. Then you add the other arguments needed
    //for the constructor such as title and any others you may need and add the : base(arguments from base class)
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) //Remember you need to have the : base() in order to pass the 
    //information from the base class into the inheritance class.
    {
        _title = title;
    }
    //Getters
    public string GetWritingInformation()
    {
        return $"Writing assignment title: {_title}";
    }

}