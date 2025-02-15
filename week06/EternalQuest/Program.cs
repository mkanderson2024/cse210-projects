using System;

class Program
{
    static void Main(string[] args)
    {
        //Constants
        int menuInput = -1;
        Console.Clear();
        bool exit = false;
        Console.WriteLine("Welcome to the goals manager program.");
        while (exit == false)
        {
            GoalManager program = new GoalManager();
            program.Start();
            //=========Main Menu=============
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
                menuInput = 88;
            }
            // List Goals
            if (menuInput == 2)
            {
                program.ListGoalDetails();
            }
            // Save Goals
            if (menuInput == 3)
            {

            }
            // Load Goals
            if (menuInput == 4)
            {

            }
            // Record Event
            if (menuInput == 5)
            {

            }
            // Quit
            if (menuInput == 6)
            {
                Console.WriteLine("Thank you for using goals manager program! Closing Program");
                program.LoadingAnimation();
                Console.WriteLine("Until Next Time! -----");
                Thread.Sleep(2000);
                Console.Clear();
                exit = true;
            }
            if (menuInput == 88)
            {
                Console.WriteLine("\nGoal entered Successfully! Returning to main menu.");
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

    }
}