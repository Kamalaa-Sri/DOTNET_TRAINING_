using System; 
static class StringExtensions {
    public static int CountSentences(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        string[] sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Length;
    }
    public static int CountVowels(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        int count = 0;

        foreach (char ch in text)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                count++;
            }
        }
        return count;
    }
}

class CountSentencesandVowels
{
    public static void Main(string[] args)
    {
        string text = "this a paragraph. It has two sentences.";
        int count = text.CountSentences();
        int vowelCount = text.CountVowels();
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Sentence Count: " + count);
        Console.WriteLine("Vowel Count: " + vowelCount);
    }
}
