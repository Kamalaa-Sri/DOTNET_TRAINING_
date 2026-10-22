public class CopyArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] originalArray = new int[size];
        int[] copiedArray = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Copy(originalArray, copiedArray, size);
        Console.WriteLine("Array elements copied successfully");
        Console.Write("New array elements: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(copiedArray[i] + " ");
        }
    }
}