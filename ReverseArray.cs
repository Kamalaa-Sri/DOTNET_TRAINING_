public class ReverseArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] originalArray = new int[size];
        int[] newArray = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            newArray[i] = originalArray[size - 1 - i];
        }
        Console.WriteLine("Array elements reversed successfully");
        Console.Write("New array elements: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}