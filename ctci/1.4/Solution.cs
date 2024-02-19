namespace nuint._1._4;

public class Solution
{
    public static bool PalindromePermutation(string str)
    {
        string news = str.Replace(" ", "").ToLower();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (var cha in news)
        {
            if (dict.ContainsKey(cha))
            {
                dict[cha]++;
            }
            else
            {
                dict.Add(cha, 1);
            }
        }

        bool isEven = news.Length % 2 == 0;
        int evens = 0;
        int odds = 0;
        
        foreach (var (_, value) in dict)
        {
            if (value % 2 == 0)
            {
                evens++;
            }
            else
            {
                odds++;
            }
        }

        if (isEven)
        {
            return odds == 0 && evens > 0;
        }
        
        return odds == 1 && evens > 0;
    }
}