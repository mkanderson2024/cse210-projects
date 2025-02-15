using System;

public class GoalManager
{
    //Member Variables & Lists
    private int _goalInput = 0;
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
        DisplayPlayerInfo();
    }
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
                SimpleGoal simpleGoal = new SimpleGoal(nameResponce, descritpionResponce, pointsResponce);
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
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            string goal = g.GetDetailsString();
            Console.WriteLine($"{goal}");
        }
        Console.WriteLine("Check check check");

    }

    public void RecoredEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

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
}