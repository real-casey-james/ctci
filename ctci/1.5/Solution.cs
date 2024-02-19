namespace nuint._1._5;

public class Solution
{
    public static bool OneAway(string str1, string str2)
    {
        if (str1 == str2) return true;

        int total = str2.Length > str1.Length
            ? GetDiff(str2, str1)
            : GetDiff(str1, str2)
        ;
        
        return total == 1;
    }

    private static int GetDiff(string str1, string str2) => str1.ToArray().Except(str2.ToArray()).Count();
}