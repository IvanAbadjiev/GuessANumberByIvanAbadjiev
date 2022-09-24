namespace GuessANumber
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create random number
            Random randomNymber = new Random();
            int computerNumber = randomNymber.Next(1, 101);

            //player input

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();

                //Check the Player's Input
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("To Low");
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
