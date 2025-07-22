using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-10): ");
            string input = Console.ReadLine();
            int number;

            bool isValid = int.TryParse(input, out number);
            if (!isValid || number < 1 || number > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                return;
            }

            Console.WriteLine($"\nMultiplication Table for {number}:\n");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
