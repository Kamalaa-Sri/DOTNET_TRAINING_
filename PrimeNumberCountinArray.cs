public class PrimeNumberCountinArray
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.Write("Enter the elements of the array: ");
        int primeCount = 0;
        for(int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < size; i++)
        {
            int count = 0;
            if(arr[i] < 2)
            {
                Console.WriteLine(arr[i] + " is not a prime number.");
                continue;
            }else if(arr[i] == 2)
            {
                Console.WriteLine(arr[i] + " is a prime number.");
                primeCount++;
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
                    primeCount++;
                } else
                {
                    Console.WriteLine(arr[i] + " is not a prime number.");
                }
            }
        }
        Console.WriteLine("Total prime numbers in the array: " + primeCount);
       
    }
}