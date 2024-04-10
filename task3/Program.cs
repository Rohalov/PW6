
internal class Program
{
    private static void Main(string[] args)
    {
        var str = GetRandomString(100);
        ShowVowels(str);
    }

    private static void ShowVowels(string str)
    {
        Console.WriteLine("Vowels:");
        foreach (var item in str) 
        {
            if (isVowel(item))
            {
                Console.Write(item);
                Console.Write(new string(' ', 3));
            }
        }
    }

    private static bool isVowel(char item)
    {
        char[] vowels = { 'a', 'e', 'u', 'i', 'o' };
        return vowels.Contains(item);
    }

    private static string GetRandomString(int numberOfChars)
    {
        Random random = new Random();
        char[] englishAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string str = string.Empty;
        for (int i = 0; i < numberOfChars; i++)
        {
            str += englishAlphabet[random.Next(0, englishAlphabet.Length - 1)];
        }
        return str;
    }
}