namespace nuint._1._1;

public class Solution
{
    public static bool IsUnique(string str)
    {
        Dictionary<char, bool> dict = new Dictionary<char, bool>();

        foreach (var cha in str)
        {
            if (dict.ContainsKey(cha)) return false;
            dict.Add(cha, true);
        }

        return true;
    }
}