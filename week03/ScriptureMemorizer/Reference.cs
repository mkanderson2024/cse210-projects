using System;

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _multiVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _multiVerse = "yes";
    }

    public void GetDisplayText()
    {
        if (_multiVerse == "yes")
        {
            //May need an if statement to help with if there is multiple verses or not.
            Console.WriteLine($"{_book} {_chapter}: {_verse} - {_endVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse}");
        }
    }

}