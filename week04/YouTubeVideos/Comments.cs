using System;

public class Comment
{
    public string _name { get; set; }

    public string _comment { get; set; }
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
}