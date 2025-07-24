using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (0–999): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 999.");
            return;
        }

        if (number == 0)
        {
            Console.WriteLine("Zero");
            return;
        }

        string result = "";

        int hundreds = number / 100;
        int remainder = number % 100;
        int tens = remainder / 10;
        int ones = remainder % 10;

        if (hundreds > 0)
        {
            result += GetOnesWord(hundreds) + " Hundred";
            if (remainder > 0)
            {
                result += " ";
            }
        }

        if (remainder >= 10 && remainder <= 19)
        {
            result += GetTeenWord(remainder);
        }
        else
        {
            if (tens > 0)
            {
                result += GetTensWord(tens);
                if (ones > 0)
                {
                    result += " ";
                }
            }

            if (ones > 0)
            {
                result += GetOnesWord(ones);
            }
        }

        Console.WriteLine(result);
    }

    static string GetOnesWord(int num)
    {
        switch (num)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "";
        }
    }

    static string GetTeenWord(int num)
    {
        switch (num)
        {
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Twelve";
            case 13: return "Thirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Eighteen";
            case 19: return "Nineteen";
            default: return "";
        }
    }

    static string GetTensWord(int num)
    {
        switch (num)
        {
            case 2: return "Twenty";
            case 3: return "Thirty";
            case 4: return "Forty";
            case 5: return "Fifty";
            case 6: return "Sixty";
            case 7: return "Seventy";
            case 8: return "Eighty";
            case 9: return "Ninety";
            default: return "";
        }
    }
}
