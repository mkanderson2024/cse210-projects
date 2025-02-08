using System;

//For added creativity, added an animation and a good bye message once user chooses to quit.

class Program
{
    static void Main(string[] args)
    {
        //Constants
        Console.Clear();
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
                Console.Clear();
            }
            // Reflecting Activity
            if (userInput == 2)
            {
                ReflectingActivity a2 = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength, resiliance, and connection to the spirt in your life.");
                a2.DisplayStartingMessage();
                Console.Clear();
                a2.GetReflectionPrmopt();
                a2.Run();

            }
            //Listing Activity
            if (userInput == 3)
            {
                ListingActivity a3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can when prompted.");
                a3.DisplayStartingMessage();
                Console.Clear();
                a3.GetListingPrompt();
                a3.Run();
                a3.DisplayEndingMessage();
                a3.ShowSpinner(5);
                Console.Clear();
            }
            if (userInput == 4)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness Program! Closing Program.");
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(5);
                DateTime currentTime = DateTime.Now;
                Console.WriteLine("");
                while (currentTime < endTime)
                {
                    Console.Write("-");
                    Thread.Sleep(1000);
                    currentTime = DateTime.Now;
                }
                Console.WriteLine("Until Next time! -----");
                Thread.Sleep(2000);
                Console.Clear();
                exit = true;
            }
        }
    }
}