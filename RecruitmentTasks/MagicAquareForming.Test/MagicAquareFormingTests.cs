namespace MagicAquareForming.Test
{
    [TestClass]
    public class MagicAquareFormingTests
    {
        [TestMethod]
        public void ReultOfMagicAquareFormingShoulldBeOne()
        {
            List<List<int>> s = [[4, 9, 2], [3, 5, 7], [8, 1, 5]];

            var result = Result.FormingMagicSquare(s);

            result.Should().Be(1);
        }

        [TestMethod]
        public void ReultOfMagicAquareFormingShoulldBeFour()
        {
            List<List<int>> s = [[4, 8, 2], [4, 5, 7], [6, 1, 6]];

            var result = Result.FormingMagicSquare(s);

            result.Should().Be(4);
        }
    }
}