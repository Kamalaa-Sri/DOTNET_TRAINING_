public class SortArrayOrders
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        int[] newarray = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(array);
        Console.Write("Sorted array elements in ascending order: ");
        for(int i = 0; i < size; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine("");
        for (int i = 0; i < size; i++)
        {
            newarray[i] = array[size - 1 - i];
        }
        Console.Write("Sorted array elements in descending order: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(newarray[i] + " ");
        }
               
    }
}