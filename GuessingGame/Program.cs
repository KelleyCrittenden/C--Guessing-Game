using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretNumber = "42";

            int numberOfAttempts = 0;

            Console.WriteLine($"Can you guess the secret number? >>");

            while (numberOfAttempts < 4)
            {
                Console.WriteLine($"You have guessed {numberOfAttempts} time[s].");

                string numberGuess = Console.ReadLine();

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats, you guessed the secret number!");
                    numberOfAttempts = 4;
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