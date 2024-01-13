using System;
using System.Collections.Generic;

namespace MagicAquareForming;

public class Result
{
    public static int FormingMagicSquare(List<List<int>> s)
    {
        int[][][] possibleMagicSquares = new int[][][] {
            new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
            new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
            new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } },
            new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } },
            new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } },
            new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } },
            new int[][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } },
            new int[][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } }};

        int minCost = int.MaxValue;

        foreach (var magicSquare in possibleMagicSquares)
        {
            int cost = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(s[i][j] - magicSquare[i][j]);
                }
            }

            minCost = Math.Min(minCost, cost);
        }

        return minCost;
    }
}
