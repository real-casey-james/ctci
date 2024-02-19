namespace nuint._1._1;

public class Test
{
    [Test]
    public void TestTrue()
    {
        Assert.IsTrue(Solution.IsUnique("a"));
        Assert.IsTrue(Solution.IsUnique("qwertyuiopasdfghjklzxcvbnm"));
    }
    
    [Test]
    public void TestFalse()
    {
        Assert.IsFalse(Solution.IsUnique("aa"));
        Assert.IsFalse(Solution.IsUnique("ahdlgkjhwflkgjnaflkjvnaljdhgakjfhg"));
    }
}