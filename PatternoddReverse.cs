public class PatternoddReverse
{
    public static void Main(string[] args)
    {
        for(int i=9;i>=1;i=i-2){
           for(int j=9;j>=i;j=j-2){
               Console.Write(j+ " ");
           }
           Console.WriteLine();
       }
    }
}