class Operations
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the value of X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter an operation: ");
        string name = Console.ReadLine();

        switch (name)
        {
            case "Addition":
                Console.WriteLine("The answer after addition is:" + (x + y));
                break;
            case "Subtraction":
                Console.WriteLine("The answer after subtraction is:" + (x - y));
                break;
            case "Multiplication":
                Console.WriteLine("The answer after multiplication is:" + (x * y));
                break;
            case "Division":
                Console.WriteLine("The answer after division is:" + (x / y));
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}