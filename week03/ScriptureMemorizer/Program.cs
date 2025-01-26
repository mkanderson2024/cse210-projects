using System;

//Added a primary menu to allow for future upgrades such as the ability to add your own scriptures in. For now it creates its own scripture
class Program
{
    static void Main(string[] args)
    {
        //Starts Program and creates innitial scripture and reference.
        Console.WriteLine("Welcome to the scripture memorizing program.");
        string responceMenu = "";
        string book = "Proverbs";
        int chapter = 3;
        int beginning = 5;
        int ending = 6;
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";

        while (responceMenu == "")
        {
            Console.Write("\nTo start game press Enter or type quit to leave\n");
            responceMenu = Console.ReadLine();
            if (responceMenu == "")
            {
                Reference scriptureOne = new Reference(book, chapter, beginning, ending, text);
                scriptureOne.GetDisplayText();
                Word start = new Word();
                start.IsHiden(text);
            }
            else if (responceMenu == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid resonce");
                responceMenu = "";
            }
        }
        Console.WriteLine("Thank you for using the program");
    }
}