public class RemoveNuminString {
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (!(str[i] >= '0' && str[i] <= '9'))
            {
                result += str[i];
            }
        }
        Console.WriteLine("Output: " + result);
    }
}