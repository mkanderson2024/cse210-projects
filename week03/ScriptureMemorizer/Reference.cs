using System;

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _multiVerse;
    private string _text;
    public Reference()
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endVerse = 6;
        _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";
    }

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