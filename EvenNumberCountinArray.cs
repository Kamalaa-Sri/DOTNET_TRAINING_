public class EvenNumberCountinArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.Write("Enter the elements of the array: ");
        int count = 0;
        for(int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < size; i++)
        {
            if(arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("The count of even numbers in the array is: " + count);
    }
}
