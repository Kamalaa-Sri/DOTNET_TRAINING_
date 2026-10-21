public class Primearray
{
    public static void Main(string[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        int count = 0;
        for(int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < size; i++)
        {
            if(arr[i] < 2)
            {
                Console.WriteLine(arr[i] + " is not a prime number.");
                continue;
            }else if(arr[i] == 2)
            {
                Console.WriteLine(arr[i] + " is a prime number.");
                continue;
            }else if(arr[i] > 2)
            {
                for(int j = 2; j < arr[i]; j++)
                {
                    if(arr[i] % j == 0)
                    {
                        count++;
                    }
                   
                }
                if(count == 0)
                {
                    Console.WriteLine(arr[i] + " is a prime number.");
                } else
                {
                    Console.WriteLine(arr[i] + " is not a prime number.");
                }
            }
        }
    }
}