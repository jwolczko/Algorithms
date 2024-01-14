using System;

namespace LargestOscillatingSlice;

internal class Program
{
    static void Main()
    {
        // Example Usage:
        int[] A = [ 5, 0, -2, 6, 3, 4, 4, -3, 5 ];
        int largestOscillatingSlice = Solution.LargestOscillatingSlice(A);

        Console.WriteLine("Largest Oscillating Slice: " + largestOscillatingSlice);
    }
}