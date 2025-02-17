using System;

class Program
{
    static void Main(string[] args)
    {
        //Constants
        int menuInput = -1;
        Console.Clear();
        bool exit = false;
        GoalManager program = new GoalManager();
        program.Start();
        while (exit == false)
        {
            //=========Main Menu=============
            Console.WriteLine("\n---------Main Menu----------");
            program.DisplayPlayerInfo();
            Console.WriteLine("\nPlease choose one of the following options by entering the number");
            List<string> options = new List<string> { "1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit" };
            foreach (string option in options)
            {
                Console.WriteLine($"    {option}");
            }
            //User Inputs
            Console.Write("\nWhat would you like to do? ");
            string responce = Console.ReadLine();
            menuInput = int.Parse(responce);
            Console.Clear();

            //============Program Options==========
            // Create New Goals
            if (menuInput == 1)
            {
                program.CreateGoal();
                Console.WriteLine("\nGoal entered Successfully! Returning to main menu.");
                menuInput = 88;
            }
            // List Goals
            if (menuInput == 2)
            {
                program.ListGoalDetails();
                Console.WriteLine("\nReturning to main menu.");
                menuInput = 88;
            }
            // Save Goals
            if (menuInput == 3)
            {
                program.SaveGoals();
                Console.WriteLine("Save Complete! Returning to main menu.");
                menuInput = 88;
            }
            // Load Goals
            if (menuInput == 4)
            {
                program.LoadGoals();
                Console.WriteLine("Load successful! Returning to main menu.");
                menuInput = 88;
            }
            // Record Event
            if (menuInput == 5)
            {
                program.ListGoalNames();
                program.RecoredEvent();
                Console.WriteLine("Recorded successfully! Returning to main menu.");
                menuInput = 88;
            }
            // Quit
            if (menuInput == 6)
            {
                Console.WriteLine("Thank you for using goals manager program! Closing Program");
                program.LoadingAnimation();
                Console.WriteLine("Until Next Time! -----");
                Thread.Sleep(2000);
                menuInput = 88;
                Console.Clear();
                exit = true;
            }
            if (menuInput == 88)
            {
                Thread.Sleep(2000);
                menuInput = -1;
            }
            else
            {
                menuInput = -1;
                Console.WriteLine("Invalid input");
                Thread.Sleep(2000);
            }
        }
        Console.Clear();
    }
}