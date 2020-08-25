using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretNumber = "42";

            int numberAttempts = 0;

            while (numberAttempts < 4)
            {
                Console.WriteLine("Can you guess the secret number?");

                string numberGuess = Console.ReadLine();

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats, you guessed the secret number!");
                }
                else
                {
                    numberAttempts++;
                    Console.WriteLine("Try Again!");
                }

            }
        }
    }
}