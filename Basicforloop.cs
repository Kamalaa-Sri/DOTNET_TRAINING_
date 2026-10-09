class Basicforloop {
    public static void Main(string[] args) {
        Console.Write("Enter a number to start the loop:");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number to end the loop:");
        int end = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int sum=0;
        if(start < end)
        {
            
            for(int i=start; i<=end; i++)
            {
                
                Console.WriteLine(i);
                count++;
                sum = sum + i;
            
            }
            Console.WriteLine("The count value is: " + count);
            Console.WriteLine("The sum value is: " + sum);
        }
        else
        {
            Console.WriteLine("Printing numbers from " + end + " to " + start);
            for(int i=start; i>=end; i--)
            {
                
                Console.WriteLine(i);
                count++;
                sum = sum + i;
                
            }
            Console.WriteLine("The count value is: " + count);
            Console.WriteLine("The sum value is: " + sum);
        }
    }
}

