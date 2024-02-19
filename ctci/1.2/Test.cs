namespace nuint._1._2;

public class Test
{
    [Test]
    public void TestTrue()
    {
        Assert.IsTrue(Solution.IsPermutation("acbd", "dcab"));
        Assert.IsTrue(Solution.IsPermutation("qwertyuiop", "poiuytrewq"));
    }
    
    [Test]
    public void TestFalse()
    {
        Assert.IsFalse(Solution.IsPermutation("acbd", "zyxk"));
        Assert.IsFalse(Solution.IsPermutation("a", "zyxk"));
    }
}