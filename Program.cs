using System;

namespace WhileLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNum = new Random();
            int secretNumber = ranNum.Next(1, 100);
            Console.WriteLine(secretNumber);
            int guess = 0;
            int numOfGuesses = 0;

            Console.WriteLine("------ Number Guessing Game ------");
            Console.WriteLine("Guess A Number Between 1 - 100: ");

            while (guess != secretNumber)
            {
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    numOfGuesses += 1;

                    if (guess == secretNumber)
                    {
                        break;
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Sorry, To High. Guess Again!");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Sorry, To Low. Guess Again!!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Number, Try Again!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input, Numbers Only!");
                }
            }
            Console.WriteLine("You Won!" + " You guessed in: " + numOfGuesses + " guesses!");
        }
    }
}
