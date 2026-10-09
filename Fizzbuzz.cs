class Fizzbuzz {
    public static void Main(string[] args) {
        Console.Write("Enter a start value: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an end value: ");
        int end = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i = start; i <= end; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Printing numbers that are divisible by 9 from " + start + " to " + end);
        for(int i = start; i <= end; i++)
        {
            if(i % 9 == 0)
            {
            Console.WriteLine(i);
            sum = sum+i;
            }
        }
        Console.WriteLine("The sum of numbers divisible by 9 from " + start + " and " + end + " is: " + sum);
    }
}