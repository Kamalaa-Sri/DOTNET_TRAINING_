public class PatternK
{
    public static void Main(string[] args)
    {
        for(int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if(j==1)
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}