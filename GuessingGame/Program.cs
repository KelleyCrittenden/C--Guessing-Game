using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = new Random().Next(1, 101);

            int numberOfAttempts = 0;

            Console.WriteLine($"Can you guess the secret number? >>");

            while (numberOfAttempts < 4)
            {
                Console.WriteLine($"Attempts Remaining: {4 - numberOfAttempts}.");

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