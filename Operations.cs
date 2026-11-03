using System;
public static class Operations
{
    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Addition: " + result);
    }
    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Subtraction: " + result);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Operations.Addition(10, 5);
        Operations op = new Operations();
        op.Subtraction(10, 5);
    }
}