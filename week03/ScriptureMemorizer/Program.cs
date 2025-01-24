using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizing program.");
        string responce = "";

        while (responce == "")
        {
            string book = "Proverbs";
            int chapter = 3;
            int beginning = 5;
            int ending = 6;
            Reference scriptureOne = new Reference(book, chapter, beginning, ending);
            scriptureOne.GetDisplayText();

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