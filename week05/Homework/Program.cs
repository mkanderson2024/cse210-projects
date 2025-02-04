using System;

class Program
{
    static void Main(string[] args)
    {
        //At this point you would only need to add the two Assignment arguments.
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplaction");
        //When calling the GetSummary remember to put the () behind it or you'll get "System.Func`1[System.String]" when printing
        Console.WriteLine($"{assignment1.GetSummary()}");
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        //When calling the GetSummary you can also call it this way alternately but be sure to put the () after or you'll get the above error
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        //Remember when instatntiating WritingAssignment args: _studentName,        _topic      ,        _title                              all from the assignmetn constructor
        WritingAssignment assingment3 = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II by Mary Waters");
        Console.WriteLine(assingment3.GetSummary());
        Console.WriteLine(assingment3.GetWritingInformation());
    }
}