namespace nuint._1._6;

public class Solution
{
    public static string StringCompression(string input)
    {
        string str = "";
        char prev = input[0];
        int count = 0;

        foreach (var ch in input)
        {
            if (ch == prev)
            {
                count++;
            }
            else
            {
                str += new string([prev]) + count;
                count = 1;
                prev = ch;
            }
        }
// todo
        str += new string([prev]) + count;
        
        return str.Length < input.Length
            ? str
            : input
            ;
    }
}