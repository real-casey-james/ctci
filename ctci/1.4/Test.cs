namespace nuint._1._4;

public class Test
{
    [Test]
    public void TestTrue()
    {
        Assert.IsTrue(Solution.PalindromePermutation("Tact Coa"));
        Assert.IsTrue(Solution.PalindromePermutation("Tact Coao"));
        Assert.IsTrue(Solution.PalindromePermutation("Tact Ctat"));
    }

    [Test]
    public void TestFalse()
    {
        Assert.IsFalse(Solution.PalindromePermutation("Zxcv Bnm"));
        Assert.IsFalse(Solution.PalindromePermutation("Tact Coaa"));
    }
}