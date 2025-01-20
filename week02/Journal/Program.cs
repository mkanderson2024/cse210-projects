using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        int quit = 0;
        Console.Write("Welcome to the journal program!");
        while (userInput != quit)
        {
            Console.WriteLine("Please choose one of the following options by entering the number:");
            List<string> options = new List<string> { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.Write("What would you like to do? ");
            string responce = Console.ReadLine();
            userInput = int.Parse(responce);

            if (userInput == 1)
            {
                // Creates prompt and displays for user
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write(">");
                // Creates user text
                string entryText = Console.ReadLine();
                // Time stamps
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry theEntry = new Entry();
                theEntry._date = dateText;
                theEntry._entryText = entryText;
                theEntry._promptText = randomPrompt;
                theEntry.Display();
                // Writes entry to entries list in Journal
                Journal newEntry = new Journal();
                newEntry._entries.Add(theEntry);
            }

            else if (userInput == 2)
            {

            }

            else if (userInput == 3)
            {

            }

            else if (userInput == 4)
            {
                Console.Write("Input name for file: ");
                string fileName = Console.ReadLine();
                Journal saveFile = new Journal();
                saveFile.SaveToFile(fileName);

            }

            else
            {
                userInput = -1;
            }







        }

    }
}