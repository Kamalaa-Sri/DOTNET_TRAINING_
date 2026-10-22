public class CountVowelsAndConString {
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        int vowels = 0;
        int consonants = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
        Console.WriteLine("Vowels = " +vowels);
        Console.WriteLine("Consonants = " +consonants);
    }
}