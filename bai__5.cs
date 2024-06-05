
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            
            int guess = 0;

            
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

            
            while (guess != secretNumber)
            {
                
                Console.Write("Your guess: ");
                guess = int.Parse(Console.ReadLine());

                
                if (guess < secretNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"Correct! The secret number was {secretNumber}.");
                    break; 
                }
            }
        }
    }
}