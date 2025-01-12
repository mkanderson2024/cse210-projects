using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string replay = "Yes";
        string answer = "Yes";

        while (replay == answer)
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            string cont = "yes";
            string stop = "no";
            int guessCount = 0;

            while (cont != stop)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                int guess = int.Parse(userGuess);
                guessCount += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    cont = "yes";
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                    cont = "yes";
                }
                else
                {
                    Console.WriteLine($"You got it in {guessCount} guesses!");
                    cont = "no";
                }
            }

            Console.Write("Play again? Yes to contine and No to stop: ");
            answer = Console.ReadLine();
        }
    }
}