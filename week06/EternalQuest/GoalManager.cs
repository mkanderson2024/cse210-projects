using System;
using System.IO;
//For added creativity, added a section that presents "Player levels" based upon score capping out at high flying unicorn found in the DisplayPlayerInfo method.
public class GoalManager
{
    //Member Variables & Lists
    private int _goalInput;
    List<Goal> _goals = new List<Goal>();
    List<string> _goalTypes = new List<string> { "1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal" };
    private int _score;
    //Constructor
    public GoalManager()
    {

    }
    //Methods
    public void Start()
    {
        Console.WriteLine("Welcome to the goals manager program.");
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
                int completed = 0;

                ChecklistGoal checklistGoal = new ChecklistGoal(nameResponce, descritpionResponce, pointsResponce, bonus, completed, target);
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
        Console.WriteLine($"\nYou currently have {_score} points.");
        Console.WriteLine("\n------Player Levels-------\n");
        if (_score >= 0)
        {
            Console.Write(" |Noob. Just noob.| ");
        }
        if (_score >= 100)
        {
            Console.Write(" |Not so noobish...| ");
        }
        if (_score >= 1000)
        {
            Console.Write(" |Goal Getting Golum!| ");
        }
        if (_score >= 10000)
        {
            Console.Write(" |High flying unicorn!| ");
        }
        else
        {
            Console.Write(" |Doing more point mining>");
        }
        Console.WriteLine("\n\n--------------------------");
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
        Console.WriteLine("-----Goals List-----");
        int counter = 0;
        foreach (Goal g in _goals)
        {
            counter += 1;
            string goal = g.GetDetailsString();
            Console.WriteLine($"{counter}. {goal}");
        }
        Console.Write("\nPress Enter to continue");
        Console.ReadLine();
    }
    //Record Events
    public void RecoredEvent()
    {
        Console.Write("Which goal would you like to record an event for? ");
        string userInput = Console.ReadLine();
        int goalInteger = int.Parse(userInput);
        goalInteger--;
        var goal = _goals.ElementAt(goalInteger);
        goal.IsComplete();
        _score += goal.RecordEvent();

    }
    public void SaveGoals()
    {
        Console.Write("Enter name of file with txt file type. Example: myfile.txt ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Adds score to text file
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                string outPutText = g.GetStringRepresentation();

                {
                    //Adds goals to text
                    outputFile.WriteLine($"{outPutText}");
                }
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter name of txt file you'd like to load. Example: myFile.txt ");
        string fileName = Console.ReadLine();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string scoreLine = reader.ReadLine() ?? "";
            int score = int.Parse(scoreLine);
            _score += score;
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        char[] delimiterChars = { ',', '.', ':', };
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split(delimiterChars);
            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            string points = parts[3];
            //For ChecklistGoals
            if (type == "ChecklistGoal")
            {
                string bonus = parts[4];
                string completed = parts[5];
                string target = parts[6];
                //Check Spot
                // Console.WriteLine($"{type},{shortName},{description},{points},{bonus},{completed},{target}");
                int ibonus = int.Parse(bonus);
                int icompleted = int.Parse(completed);
                int itarget = int.Parse(target);
                ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, ibonus, icompleted, itarget);
                _goals.Add(checklistGoal);
            }
            //For Simple Goal
            else if (type == "SimpleGoal")
            {
                string isComplete = parts[4];
                //Check Spot
                // Console.WriteLine($"{type},{shortName},{description},{points}, {isComplete}");
                bool simpleBool = bool.Parse(isComplete);
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, simpleBool);
                _goals.Add(simpleGoal);

            }
            //For Eternal Goal
            else
            {
                //Check Spot
                // Console.WriteLine($"{type},{shortName},{description},{points}");
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                _goals.Add(eternalGoal);
            }
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
        _score += score;
        return _score;
    }

}