public class ReverseChar
{
    public static void Main(String[] args)
    {
        for(char i = 'E'; i >= 'A'; i--)
        {
            for (char j = 'A'; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}