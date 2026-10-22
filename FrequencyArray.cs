public class FrequencyArray
{
    public static void Main(string[] args)
    {
        
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            int count = 1;
            for (int k = 0; k < i; k++)
            {
                if (arr[i] == arr[k])
                {
                    count = 0;
                    break;
                }
            }
            if (count != 0)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("The frequency of " + arr[i] + " is: " + count);
            }
        }
    }
}