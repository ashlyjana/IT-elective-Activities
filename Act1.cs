using System;

namespace Activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            while (true)
            {
                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(firstName))
                    break;

                Console.WriteLine("First name cannot be empty. Please try again.");
            }
            while (true)
            {
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(lastName))
                    break;

                Console.WriteLine("Last name cannot be empty. Please try again.");
            }
            Console.WriteLine($"Your full name is: {firstName} {lastName}");
        }
    }
}
