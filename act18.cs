using System;

class Program
{
    static void Main()
    {
      Console.Write("Enter a positive number to start countdown: ");
      string input = Console.ReadLine();
      int number;
      
      bool isValid = int.TryParse(input, out number);
      if (!isValid || number <= 0)
      {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
        return;
        
        Console.WriteLine("\nCountdown: ");
        while (number >= 0)
        {
          Console.WriteLine(number);
          number--;
    }
}
