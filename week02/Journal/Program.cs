using System;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
/// <summary>
/// Creativity additions:
/// Created back up file system fo errors and system crash (I'd really really REALLY hate to loose a journal)
/// Added file based loaded and saving. Files are copied from or to back up file system.
/// Lots of user friendly visuals.
/// </summary>
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
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            string responce = Console.ReadLine();
            userInput = int.Parse(responce);

            if (userInput == 1) //Write
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
                string textSave = theEntry.Convert();
                Journal newEntry = new Journal();
                newEntry.AddEntry(textSave, "journalBackupFile.txt");
            }

            else if (userInput == 2) //Display
            {
                Console.WriteLine("\n");
                Journal review = new Journal();
                review.DisplayAll();
            }

            else if (userInput == 3) //Load
            {
                Console.Write("Input name of file to load: ");
                string fileName = Console.ReadLine();
                Journal loadFile = new Journal();
                loadFile.LoadFromFile(fileName);
            }

            else if (userInput == 4) //Save
            {
                Console.Write("Input name for file: ");
                string fileName = Console.ReadLine();
                Journal saveFile = new Journal();
                saveFile.SaveNewFile(fileName);

            }
            else if (userInput == 5) //Quit
            {
                string backUpFile = @"journalBackupFile.txt";
                File.Delete(backUpFile);
                userInput = 0;
                Console.WriteLine("\nThank you for journaling today");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
            }
            else //Recycle menu
            {
                userInput = -1;
            }
        }
    }
}
// Alternative Coding to help understand
//  if (choice == 1)
//             {
//                 string randomPrompt = prompt.GetRandomPrompt();
//                 Console.WriteLine($"{randomPrompt}");
//                 Console.Write("Journal entry: ");
//                 string entryText = Console.ReadLine();

//                 DateTime theCurrentTime = DateTime.Now;
//                 string date = theCurrentTime.ToShortDateString();

//                 Entry newEntry = new Entry
//                 {
//                     _date = date,
//                     _prompt = randomPrompt,
//                     _entry = entryText
//                 };

//                 journal.AddEntry(newEntry);
//                 Console.WriteLine("Your journal entry has been added!\n");
//             }

//             else if (choice == 2)
//             {
//                 journal.DisplayAllEntries();
//             }

//             else if (choice == 3)
//             {
//                 Console.Write("Enter the file you would like to load: ");
//                 string fileName = Console.ReadLine();
//                 journal.Load(fileName);
//                 Console.WriteLine($"{fileName} has been loaded!\n");
//             }
//             else if (choice == 4)
//             {
//                 Console.Write("Please enter a file name: ");
//                 string fileName = Console.ReadLine();
//                 journal.Save(fileName);
//                 Console.WriteLine("Your entries have been saved!\n");
//             }
//             else if (choice == 5)
//             {
//                 Console.WriteLine("Thanks for using the Journal Program. Goodbye!");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid entry. Please try again.");
//             }


//         } while (choice != 5);