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
        Reference scriptureOne = new Reference(book, chapter, beginning, ending, text);
        scriptureOne.GetDisplayText();


        while (responce == "")
        {
            Console.Write("To continue click ENTER key or type quit to exit ");
            responce = Console.ReadLine();
            if (responce == "")
            {
                
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