using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("[1] Greet");
        Console.WriteLine("[2] Show Date");
        Console.WriteLine("[3] Exit");

        Console.Write("Enter your choice (1-3): ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out int choice);

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("Hello, User!");
                break;
            case 2:
                Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString());
                break;
            case 3:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid option. Please choose between 1 to 3.");
                break;
        }
    }
}
