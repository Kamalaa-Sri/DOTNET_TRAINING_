public class Multitable
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to print its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication table for " + num + ":");
        int result;
        for (int i=1; i<=10; i++)
        {
            result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
        }
    }
}