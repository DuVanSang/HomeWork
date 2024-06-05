using System;

namespace AsteriskPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            string rowInput = Console.ReadLine();

            Console.WriteLine("Enter the number of columns:");
            string colInput = Console.ReadLine();

           
            if (int.TryParse(rowInput, out int rows) && rows > 0 &&
                int.TryParse(colInput, out int columns) && columns > 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive integers for rows and columns.");
            }
        }
    }
}

