using System;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playerNumber); //converts the string representation of a number to its 32-bit signed integer
                                                                                //equivalent. A return value indicates whether the operation succeeded.
                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed the number!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too high.");
                    }
                    else if (playerNumber < computerNumber)
                    {
                        Console.WriteLine("Too low.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
