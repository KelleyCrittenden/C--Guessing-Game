using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = new Random().Next(1, 101);

            int numberOfAttempts = 0;

            int attemptsAvailable = 0;

            bool difficultyLevel = false;

            while (!difficultyLevel)
            {

                Console.WriteLine("Choose a level of Difficulty? Easy, Medium, Hard or Cheater");
                string difficultyLevelChosen = Console.ReadLine();

                if (difficultyLevelChosen == "Easy")
                {
                    attemptsAvailable = 8;
                    difficultyLevel = true;
                }
                else if (difficultyLevelChosen == "Medium")
                {
                    attemptsAvailable = 6;
                    difficultyLevel = true;
                }
                else if (difficultyLevelChosen == "Hard")
                {
                    attemptsAvailable = 4;
                    difficultyLevel = true;
                }
                // else if (difficultyLevelChosen == "Cheater")
                // {
                //     attemptsAvailable = ;
                //     difficultyLevel = true;
                // }
            }

            Console.WriteLine($"Can you guess the secret number? >>");

            while (numberOfAttempts < attemptsAvailable)
            {
                Console.WriteLine($"Attempts Remaining: {attemptsAvailable - numberOfAttempts}.");

                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats, you guessed the secret number!");
                    break;
                }
                else if (numberGuess > secretNumber)
                {
                    Console.WriteLine("Your guess was too high");
                    numberOfAttempts++;
                }
                else if (numberGuess < secretNumber)
                {
                    Console.WriteLine("Your guess was too low");
                    numberOfAttempts++;
                }
                else
                {
                    numberOfAttempts++;
                    Console.WriteLine("Try Again!");
                }

            }
        }
    }
}