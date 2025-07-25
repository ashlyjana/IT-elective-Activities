using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        
        bool isPalindrome = true;

        // Convert to lowercase to make the comparison case-insensitive
        word = word.ToLower();

        // Compare characters from start and end
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
