namespace BetweenTwoSets;
public class Result
{
    static int GreatestCommonDivisor(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    static int LeastCommonMultiple(int x, int y)
    {
        return x * y / GreatestCommonDivisor(x, y);
    }

    /* Solve: https://www.hackerrank.com/challenges/between-two-sets/problem?isFullScreen=true */
    public static int GetTotalX(List<int> setA, List<int> setB)
    {
        // Find the least common multiple (LCM) of elements in 'a'
        int leastCommonMultipleA = setA[0];
        for (int i = 1; i < setA.Count; i++)
        {
            leastCommonMultipleA = LeastCommonMultiple(leastCommonMultipleA, setA[i]);
        }

        // Find the greatest common divisor (GCD) of elements in 'b'
        int breatestCommonDivisorB = setB[0];
        for (int i = 1; i < setB.Count; i++)
        {
            breatestCommonDivisorB = GreatestCommonDivisor(breatestCommonDivisorB, setB[i]);
        }

        // Count the multiples of leastCommonMultipleA that are factors of breatestCommonDivisorB
        int count = 0;
        int multiple = leastCommonMultipleA;
        while (multiple <= breatestCommonDivisorB)
        {
            if (breatestCommonDivisorB % multiple == 0)
            {
                count++;
            }
            multiple += leastCommonMultipleA;
        }

        return count;
    }
}