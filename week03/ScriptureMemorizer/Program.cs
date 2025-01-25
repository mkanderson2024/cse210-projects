using System;

class Program
{
    static void Main(string[] args)
    {
        //Starts Program and creates innitial scripture and reference.
        Console.WriteLine("Welcome to the scripture memorizing program.");
        string responce = "";
        string book = "Proverbs";
        int chapter = 3;
        int beginning = 5;
        int ending = 6;
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";

        while (responce == "")
        {
            Console.Write("To start game press Enter ");
            responce = Console.ReadLine();
            if (responce == "")
            {
                Reference scriptureOne = new Reference(book, chapter, beginning, ending, text);
                scriptureOne.GetDisplayText();
                Word start = new Word();
                start.IsHiden(text);
            }
            else if (responce == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid resonce");
                responce = "";
            }
        }
        Console.WriteLine("Thank you for using the program");
    }
}