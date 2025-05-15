using System;
using PrimeFactorLibrary;

namespace PrimeFactorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 2 and 100 to get its prime factors:");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                try
                {
                    string factors = PrimeFactorizer.PrimeFactors(number);
                    Console.WriteLine($"Prime factors of {number} are: {factors}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
