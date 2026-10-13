public class Patternodd
{
    public static void Main(string[] args)
    {
        for(int i=1;i<=9;i=i+2){
           for(int j=1;j<=i;j=j+2){
               Console.Write(j+ " ");
           }
           Console.WriteLine();
       }
    }
}