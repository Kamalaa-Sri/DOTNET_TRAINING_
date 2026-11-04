using System; 
static class StringExtensions
{
    public static void JoinName(this string firstName,string middleName, string lastName)
    {
         Console.WriteLine(string.Concat(firstName, " ", middleName, " ", lastName));
    }

}
public class ConcatName
{
    static void Main(string[] args)
    {
        string firstName = "UPS";
        string middleName = "C#";   
        string lastName = "Training";
        firstName.JoinName(middleName, lastName);

    }
}
