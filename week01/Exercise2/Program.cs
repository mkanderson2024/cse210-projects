using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse (userInput);
        string gradeLetter = "";
        string gradeSign = "";

        if (grade >= 93)
        {
            gradeLetter = "A";
            if (grade >= 90 && grade <= 93)
            {
                gradeSign = "-";
            }
            else
            {
                gradeSign = "";
            }
        }
        else if (grade < 90 && grade >= 80)
        {
            gradeLetter = "B";
            if (grade >= 80 && grade <= 83)
            {
                gradeSign = "-";
            }
            else if (grade >= 87 && grade < 90)
            {
                gradeSign = "+";
            }
            else
            {
                gradeSign = "";
            }
        }
        else if (grade >= 70 && grade < 80)
        {
            gradeLetter = "C";
                       if (grade >= 70 && grade <= 73)
            {
                gradeSign = "-";
            }
            else if (grade >= 77 && grade < 80)
            {
                gradeSign = "+";
            }
            else
            {
                gradeSign = "";
            }
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeLetter = "D";
                       if (grade >= 60 && grade <= 63)
            {
                gradeSign = "-";
            }
            else if (grade >= 67 && grade < 70)
            {
                gradeSign = "+";
            }
            else
            {
                gradeSign = "";
            }
        }
        else 
        {
            gradeLetter = "F";
        }
        Console.WriteLine ($"Your grade is {gradeLetter}{gradeSign}");

        if (grade >= 70)
        {
            Console.WriteLine ("Congratulations, you're passing!");
        }
        else
        {
            Console.WriteLine ("You are not passing. Try again, you can do this!");
        }
    }
}