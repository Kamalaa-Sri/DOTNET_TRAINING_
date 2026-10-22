public class RemoveSpecCharinString {
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9'))
            {
                result += ch;
            }
        }
        Console.WriteLine("Output: " + result);
    }
}