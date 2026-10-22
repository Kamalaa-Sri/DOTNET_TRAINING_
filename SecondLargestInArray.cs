public class SecondLargestInArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(array);
        Console.Write("Sorted array elements: ");
        for(int i = 0; i < size; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine("");
        Console.WriteLine("The second largest element in the array is: " + array[size-2]);
    }
}