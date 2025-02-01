using System;

public class Video
{
    public string _title;
    public string _author;
    public int _seconds;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _seconds = length;
    }
    public void AddComments(string name, string comment)
    {
        Comment addingComments = new Comment(name, comment);
        _comments.Add(addingComments);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"\nTitle: {_title} - {_author}, {_seconds}");
        Console.WriteLine($"Total Comments: {CommentCount()}");
        Console.WriteLine("-- Comments --");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._comment}");
        }
    }
}