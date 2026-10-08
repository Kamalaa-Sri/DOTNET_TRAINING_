class Bill
{
    public static void Calculate()
    {
        Console.WriteLine("Bill Receipt");
        Console.Write("Enter the product name: ");
        string? productName = Console.ReadLine();

        Console.Write("Enter the product quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the product price: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        decimal total = quantity * price;
        Console.WriteLine($"Receipt for {productName}: total = {total}");
    }
}

