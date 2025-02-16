using System;
using System.IO;

public class GoalManager
{
    //Member Variables & Lists
    private int _goalInput = 0;
    List<Goal> _goals = new List<Goal>();
    List<string> _goalTypes = new List<string> { "1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal" };
    List<string> _eternalResponces = new List<string>();
    List<string> _simpleResponces = new List<string>();
    private int _score;
    //Constructor
    public GoalManager()
    {

    }
    //Methods
    public void Start()
    {
        DisplayPlayerInfo();
    }
    //Create New Goals
    public void CreateGoal()
    {
        bool enterGoal = false;
        Console.WriteLine("\nThe following are the types of goals:");
        while (enterGoal == false)
        {
            foreach (string goalType in _goalTypes)
            {
                Console.WriteLine($"    {goalType}");
            }
            Console.Write("\nPlease enter goal type: ");
            string responce = Console.ReadLine();
            _goalInput = int.Parse(responce);
            //Simple Goal
            if (_goalInput == 1)
            {
                Console.Write("What is a short name for this simple goal? ");
                string nameResponce = Console.ReadLine();

                Console.Write("What is the description for this simple goal? ");
                string descritpionResponce = Console.ReadLine();

                Console.Write("How many points is this simple goal worth? ");
                string pointsResponce = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(nameResponce, descritpionResponce, pointsResponce, false);
                _goals.Add(simpleGoal);
                _goalInput = 0;
            }
            //Eternal Goal
            if (_goalInput == 2)
            {
                Console.Write("What is a short name for this eternal goal? ");
                string nameResponce = Console.ReadLine();

                Console.Write("What is the description for this eternal goal? ");
                string descritpionResponce = Console.ReadLine();

                Console.Write("How many points is this eternal goal worth? ");
                string pointsResponce = Console.ReadLine();
                EternalGoal eternalGoal = new EternalGoal(nameResponce, descritpionResponce, pointsResponce);
                _goals.Add(eternalGoal);
                _goalInput = 0;
            }
            //Checklist Goal
            if (_goalInput == 3)
            {
                Console.Write("What is a short name for this checklist goal? ");
                string nameResponce = Console.ReadLine();

                Console.Write("What is the description for this checklist goal? ");
                string descritpionResponce = Console.ReadLine();

                Console.Write("How many points is this checklist goal worth? ");
                string pointsResponce = Console.ReadLine();

                Console.Write("How many times do you want to repeat this checklist goal? ");
                string targetResponce = Console.ReadLine();
                int target = int.Parse(targetResponce);

                Console.Write("What is the bonus points value for this checklist goal? ");
                string bonusResponce = Console.ReadLine();
                int bonus = int.Parse(bonusResponce);

                ChecklistGoal checklistGoal = new ChecklistGoal(nameResponce, descritpionResponce, pointsResponce, target, bonus);
                _goals.Add(checklistGoal);
                _goalInput = 0;
            }
            if (_goalInput == 0)
            {
                enterGoal = true;
            }
            else
            {
                Console.WriteLine("Invalid Entry. Please enter 1, 2, or 3.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points.");
    }
    //Show list of Goal Names
    public void ListGoalNames()
    {
        int counter = 0;
        List<int> indexes = new List<int> { };
        foreach (Goal g in _goals)
        {
            counter += 1;
            string name = g.GetName();
            Console.WriteLine($"{counter}. {name}");
            indexes.Add(counter - 1);
        }
    }
    //Show list of Goals and details
    public void ListGoalDetails()
    {
        int counter = 0;
        foreach (Goal g in _goals)
        {
            counter += 1;
            string goal = g.GetDetailsString();
            Console.WriteLine($"{counter}. [] {goal}");
        }
        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }
    //Record Events
    public void RecoredEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for? ");
        string userInput = Console.ReadLine();
        int goalInteger = int.Parse(userInput);
        goalInteger--;

        // System.Type observedType = _goals[goalInteger].GetType();
        // if (observedType == typeof(SimpleGoal))
        // {
        IEnumerable<Goal> filteredItems = GetFilteredItems(_goals);
        foreach (Goal item in filteredItems)
        {
            // do sth with your filtered items
        }
        // SimpleGoal sg = new SimpleGoal(nameResponce, descritpionResponce, pointsResponce, false);
        // List<string> list = new List<string>();
        // list = SimpleGoal.ReturnList();
        // }
    }
    public IEnumerable<Goal> GetFilteredItems(IEnumerable<Goal> collection)
    {
        foreach (Goal item in collection)
            if (Matches<Goal>(item))
            {
                yield return item;
            }
    }

    public void SaveGoals()
    {
        Console.Write("Enter name of file with txt file type. Example: myfile.txt ");
        string fileName = Console.ReadLine();
        foreach (Goal g in _goals)
        {
            string outPutText = g.GetStringRepresentation();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                outputFile.WriteLine($"{outPutText}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter name of txt file you'd like to load. Example: myFile.txt ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string shortName = parts[0];
            string description = parts[1];
            string points = parts[3];
            string bonus = parts[4];
            string target = parts[5];
            Console.WriteLine($"{shortName},{description},{points},{bonus},{target}");
        }
    }
    public void LoadingAnimation()
    {
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
    }
    //Setters
    public int SetScore(int score)
    {
        _score = score;
        return _score;
    }

}