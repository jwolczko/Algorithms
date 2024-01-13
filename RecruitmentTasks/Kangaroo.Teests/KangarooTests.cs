namespace Kangaroo.Teests;

[TestClass]
public class KangarooTests
{
    protected const string Yes = "YES";
    protected const string No = "NO";

    [DataRow(0, 3, 4, 2, Yes)]
    [DataRow(0, 2, 5, 3, No)]
    [DataTestMethod]
    public void KangarooResultShouldHaveCorrectResult(int x1, int v1, int x2, int v2, string exspactedResult)
    {
        var result = Result.Kangaroo(x1, v1, x2, v2);
        result.Should().Be(exspactedResult);
    }
}