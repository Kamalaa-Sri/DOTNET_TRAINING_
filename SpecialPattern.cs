public class SpecialPattern
{
    public static void Main(string[] args)
    {
        for(int i=1;i<=5;i=i++){
           for(int j=1;j<=i;j=j++){
               Console.Write(j+ " ");
           }
           Console.WriteLine();
       }
    }
}