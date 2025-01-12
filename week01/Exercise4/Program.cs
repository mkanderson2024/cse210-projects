using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        List<int> numbers = new List<int>();
        while (input != 0)
        {
            Console.Write("Enter a number. Type 0 when done: ");
            string responce = Console.ReadLine();
            input = int.Parse(responce);
            numbers.Add(input);
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The Sum is: {sum}");
        double average = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The Average is: {average}");
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");
    }
}