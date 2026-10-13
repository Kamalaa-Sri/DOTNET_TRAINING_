public class Reverse
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Printing numbers from " +start+ " to " +end+ ":");
        for (int i=start; i>=end; i--)
        {
            Console.Write(i+ " ");
        } 
    }
}