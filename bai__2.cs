using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1 for Monday, 2 for Tuesday, etc.):");
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out int dayNumber))
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("The day is Monday.");
                        break;
                    case 2:
                        Console.WriteLine("The day is Tuesday.");
                        break;
                    case 3:
                        Console.WriteLine("The day is Wednesday.");
                        break;
                    case 4:
                        Console.WriteLine("The day is Thursday.");
                        break;
                    case 5:
                        Console.WriteLine("The day is Friday.");
                        break;
                    case 6:
                        Console.WriteLine("The day is Saturday.");
                        break;
                    case 7:
                        Console.WriteLine("The day is Sunday.");
                        break;
                    default:
                        Console.WriteLine("Invalid number. Please enter a number between 1 and 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

