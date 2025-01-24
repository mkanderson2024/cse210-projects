using System;

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _multiVerse;
    private string _text;
    public Reference(string book, int chapter, int verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
    }
    public Reference(string book, int chapter, int verse, int endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _multiVerse = "yes";
        _text = text;
    }
    public string Text
    {
        get {return _text;}
    }

    public void GetDisplayText()
    {
        if (_multiVerse == "yes")
        {
            //May need an if statement to help with if there is multiple verses or not.
            Console.WriteLine($"{_book} {_chapter}: {_verse}-{_endVerse} {_text}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse} {_text}");
        }
    }

}