using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        string namePrint = PromptUserName(name);
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        int numberOriginal = PromtUserNumber(number);
        int numberPrint = SquareNumber(numberOriginal);
        DisplayResult(namePrint, numberPrint);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(string userName)
    {
        string resultName = userName;
        return resultName;
    }
    static int PromtUserNumber(int numberFavorite)
    {
        int resultNumber = numberFavorite;
        return resultNumber;
    }
    static int SquareNumber(int numberFavorite)
    {
        int result = numberFavorite * numberFavorite;
        return result;
    }
    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, your favorite number squared is: {numberSquared}");
    }
}