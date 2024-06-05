using System;

namespace PositiveNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;

            
            Console.WriteLine("Enter a series of numbers (enter a negative number to stop):");

            
            while (true)
            {
                
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                
                if (number < 0)
                {
                    break;
                }

                
                if (number > 0)
                {
                    sum += number;
                }
                else
                {
                    
                    continue;
                }
            }

            
            Console.WriteLine($"The sum of the positive numbers is: {sum}");
        }
    }
}