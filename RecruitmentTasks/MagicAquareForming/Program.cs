using System;
using System.Collections.Generic;

namespace MagicAquareForming;

internal class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        List<List<int>> s = [[4, 9, 2], [3, 5, 7], [8, 1, 5]];

        int result = Result.FormingMagicSquare(s);
        Console.WriteLine(result);
    }
}