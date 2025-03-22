using System;

namespace FactorFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable and store the number we enter
            int number;

            // Ask the user to enter a number
            Console.WriteLine("Enter a number to find its factors:");
            number = int.Parse(Console.ReadLine());

            // Check the enter number is positive
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                Console.WriteLine($"Factors of {number}:");

                // Loop through all numbers from 1 to the entered number
                for (int i = 1; i <= number; i++)
                {
                    // Check if the number divides evenly
                    if (number % i == 0)
                    {
                        // Display the factor
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
