using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse (userInput);

        if (grade >= 90)
        {
            Console.WriteLine ("Your grade is: A");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine ("Your grade is: B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine ("Your grade is: C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine ("Your grade is: D");
        }
        else 
        {
            Console.WriteLine ("Your grade is: F");
        }
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