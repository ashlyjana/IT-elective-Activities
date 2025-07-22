using System;

class Program
{
    static void Main(string[] args)
    {
        float price;
        int quantity;

        Console.Write("Enter the price of the item: ");
        string priceInput = Console.ReadLine();
        bool isValidPrice = float.TryParse(priceInput, out price);

        if (!isValidPrice || price <= 0)
        {
            Console.WriteLine("Invalid input. Price must be a positive number.");
            return;
        }

        Console.Write("Enter the quantity: ");
        string quantityInput = Console.ReadLine();
        bool isValidQuantity = int.TryParse(quantityInput, out quantity);

        if (!isValidQuantity || quantity <= 0)
        {
            Console.WriteLine("Invalid input. Quantity must be a positive whole number.");
            return;
        }

        float total = price * quantity;
        Console.WriteLine($"Total cost: Php {total:F2}");
    }
}
