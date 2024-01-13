namespace AppleAndOrange;

internal class Program
{
    static void Main(string[] args)
    {
        string[] firstMultipleInput = "7 11".Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = "5 15".TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = "3 2".TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = "-2 2 1".TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = "5 -6".TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        var result = Result.CountApplesAndOranges(s, t, a, b, apples, oranges);
        Console.WriteLine(result.AppleCount);
        Console.WriteLine(result.OrangeCount);
    }
}
