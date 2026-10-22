public class SumArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int sum = 0;

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }
        

        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}