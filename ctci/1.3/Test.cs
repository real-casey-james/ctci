namespace nuint._1._3;

public class Test
{
    [Test]
    public void Test1()
    {
        StringAssert.AreEqualIgnoringCase("Mr%20John%20Smith", Solution.URLify("Mr John Smith"));
    }
}