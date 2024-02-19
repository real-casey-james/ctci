namespace nuint._1._6;

public class Test
{
    [Test]
    public void Test1()
    {
        StringAssert.AreEqualIgnoringCase("a2b1c5a3", Solution.StringCompression("aabcccccaaa"));
        StringAssert.AreEqualIgnoringCase("abcde", Solution.StringCompression("abcde"));
    }
}