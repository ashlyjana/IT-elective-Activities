using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Convert to 'upper' or 'lower': ");
        string choice = Console.ReadLine().ToLower(); 
      
        string result = "";

        foreach (char c in sentence)
        {
            if (choice == "upper")
            {
                
                if (c >= 'a' && c <= 'z')
                {
                    result += (char)(c - 32); 
                }
                else
                {
                    result += c;
                }
            }
            else if (choice == "lower")
            {
                
                if (c >= 'A' && c <= 'Z')
                {
                    result += (char)(c + 32);
                }
                else
                {
                    result += c; 
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'upper' or 'lower'.");
                return;
            }
        }

        Console.WriteLine("Converted: " + result);
    }
}
