namespace AppleAndOrange.Tests;

[TestClass]
public class AppleAndOrangeTests
{
    [TestMethod]
    public void CountApplesAndOrangesShouldReturnCorrectResults()
    {
        List<int> apples = [-2, 2, 1];
        List<int> oranges = [5, -6];

        var result = Result.CountApplesAndOranges(7, 11, 5, 15, apples, oranges);

        result.AppleCount.Should().Be(1);
        result.OrangeCount.Should().Be(1);
    }
}