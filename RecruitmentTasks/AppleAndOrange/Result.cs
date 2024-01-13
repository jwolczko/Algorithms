namespace AppleAndOrange;

public class Result
{
    //Solution for task https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
    public static (int AppleCount, int OrangeCount) CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (var apple in apples)
        {
            int applePosition = a + apple;
            if (applePosition >= s && applePosition <= t)
            {
                appleCount++;
            }
        }

        foreach (var orange in oranges)
        {
            int orangePosition = b + orange;
            if (orangePosition >= s && orangePosition <= t)
            {
                orangeCount++;
            }
        }

        return (appleCount, orangeCount);
    }
}
