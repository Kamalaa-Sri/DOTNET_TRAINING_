class CopyArrayCheck{
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
        for (int i = 0; i < size; i++)
        {
            if (originalArray[i] == copiedArray[i])
            {
                Console.WriteLine("Element at index " + i + " is copied correctly.");
            }
            else
            {
                Console.WriteLine("Element at index " + i + " is not copied correctly.");
            }
            
        }
    }
}