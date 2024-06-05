using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            
            if (number < 1)
            {
                Console.WriteLine("Error: Number must be a positive integer.");
                return;
            }

            
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
    }
}
