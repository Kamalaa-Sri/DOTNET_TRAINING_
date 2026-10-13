public class Oddnum
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Printing odd numbers from " +start+ " to " +end+ ":");
        for (int i=start; i<=end; i++)
        {
            if(i % 2 != 0)
            {
                Console.Write(i+ " ");
            }
        } 
      
    }
}