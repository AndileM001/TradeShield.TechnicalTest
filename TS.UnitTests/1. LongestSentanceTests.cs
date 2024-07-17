using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);

        var input2 = $"Forget CVs..Save time . x x";
        var outcome2 = LongestSentanceAnswer.Solution(input2);
        Assert.AreEqual(2, outcome2);
    }
}
