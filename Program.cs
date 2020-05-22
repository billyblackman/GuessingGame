using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);

            Console.WriteLine("Type your difficulty: Easy, Medium, Hard, or Cheater");

            string userDifficulty = Console.ReadLine();

            int guessesGiven = 8;

            if (userDifficulty == "Medium")
            {
                guessesGiven = 6;
            }
            else if (userDifficulty == "Hard")
            {
                guessesGiven = 4;
            }

            while (guessesGiven > 0)
            {
                if (userDifficulty == "Cheater")
                {
                    Console.WriteLine($"Guess the secret number. You have unlimited guesses");
                }
                else
                {
                    Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven})");
                }

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yeppers");
                    break;
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Noperooski. Too high!");
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Noperino. Too low!");
                }

                if (userDifficulty == "Cheater")
                {
                    guessesGiven++;
                }
                else
                {
                    guessesGiven--;
                }

            }

        }
    }
}