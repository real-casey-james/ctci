namespace nuint._1._2;

public class Solution
{
    public static bool IsPermutation(string str1, string str2)
    {
        return SortString(str1) == SortString(str2);
    }
    
    static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}