namespace BetweenTwoSets.Tests
{
    [TestClass]
    public class BetweenTwoSetsTests
    {
        [TestMethod]        
        public void ResultOfBetweenTwoSetsShouldBeThree()
        {
            List<int> setA = [2, 4];
            List<int> setB = [16, 32, 96];
            int exceptedResult = 3;

            var result = Result.GetTotalX(setA, setB);
            result.Should().Be(exceptedResult);
        }

        [TestMethod]
        public void ResultOfBetweenTwoSetsShouldBeTwo()
        {
            List<int> setA = [3, 4];
            List<int> setB = [24, 48];
            int exceptedResult = 2;

            var result = Result.GetTotalX(setA, setB);
            result.Should().Be(exceptedResult);
        }        
    }
}