namespace s14.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        AngleVector<int> v1 = new AngleVector<int>(3, 45);
        AngleVector<int> v2 = new AngleVector<int>(4, 45);

        AngleVector<int> vsum = v1.Add(v2);
        AngleVector<int> vExpectedsum = new AngleVector<int>(7, 45);

        Assert.AreEqual(vExpectedsum, vsum);
    }
}