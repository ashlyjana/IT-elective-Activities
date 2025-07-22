using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        string input = Console.ReadLine();

        float celsius;
        bool isValid = float.TryParse(input, out celsius);

        if (!isValid || celsius < -100 || celsius > 100)
        {
            Console.WriteLine("Invalid input. Temperature must be a number between -100 and 100.");
            return;
        }

        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
    }
}
