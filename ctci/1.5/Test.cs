namespace nuint._1._5;

public class Test
{
    [Test]
    public void TestTrue()
    {
        Assert.IsTrue(Solution.OneAway("pale", "ple"));
        Assert.IsTrue(Solution.OneAway("pales", "pale"));
        Assert.IsTrue(Solution.OneAway("pale", "pales"));
        Assert.IsTrue(Solution.OneAway("pale", "bale"));
        Assert.IsTrue(Solution.OneAway("pale", "pale"));
    }

    [Test]
    public void TestFalse()
    {
        Assert.IsFalse(Solution.OneAway("pale", "bake"));
    }
}