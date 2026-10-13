public class Patternnew
{
    public static void Main(String[] args)
    {
        for(char i = 'A'; i <= 'E'; i++)
        {
            for (char j = 'A'; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}