using System;

class Program
{
    static void Main()
    {
        string secretWord = "open";
        string userGuess;
        do
        {
            Console.Write("Guess the secret word: ");
            userGuess = Console.ReadLine();
            if (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Try again.");
            }
        } while (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Correct!");
    }
}
