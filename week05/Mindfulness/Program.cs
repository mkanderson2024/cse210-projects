using System;

class Program
{
    static void Main(string[] args)
    {
        //Constants
        int userInput = -1;
        bool exit = false;
        Console.WriteLine("Welcome to the Mindfulness activity.");
        while (exit == false)
        {
            //==============Main Menu==============
            Console.WriteLine("\nPlease choose one of the following options by entering the number:");
            List<string> options = new List<string> { "1. Start breathing activity", "2. Start Reflecting Activity", "3. Start Listing activity", "4. Quit" };
            foreach (string option in options)
            {
                Console.WriteLine($"    {option}");
            }
            //User Inputs
            Console.Write("\nWhat would you like to do? ");
            string responce = Console.ReadLine();
            userInput = int.Parse(responce);
            Console.Clear();

            //==============Program Options==============
            // BreathingActivity
            if (userInput == 1)
            {
                BreathingActivity a1 = new BreathingActivity("Breathing", "relax by walking you through breathing in and out slowly.");
                a1.DisplayStartingMessage();
                a1.Run();
                Console.Clear();
                a1.DisplayEndingMessage();
                a1.ShowSpinner(5);
            }
            if (userInput == 3)
            {
                ListingActivity a2 = new ListingActivity("Listing", "reflect on times in your life when you have shown strength, resiliance, and connection to the spirt in your life by writing it down.");
                a2.DisplayStartingMessage();
                Console.Clear();
                a2.GetRandomPrompt();

            }
        }
    }
}