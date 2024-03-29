﻿/*
    A zero-indexed array A consisting of N integers is given. The elements of array A together represent a chain, 
    and each element represents the strength of each link in the chain. We want to divide this chain into three smaller chains.

    All we can do is to break the chain in exactly two non-adjacent positions. More precisely, 
    we should break links P, Q (0 < P < Q < N − 1, Q − P > 1), resulting in three chains [0, P − 1], [P + 1, Q − 1], [Q + 1, N − 1]. 
    The total cost of this operation is equal to A[P] + A[Q].
    
    For example, consider array A such that:
    
    
                                A[0] = 5
                                A[1] = 2
                                A[2] = 4
                                A[3] = 6
                                A[4] = 3
                                A[5] = 7
                            
    We can choose to break the following links:
    
        (1, 3): total cost is 2 + 6 = 8
        (1, 4): total cost is 2 + 3 = 5
        (2, 4): total cost is 4 + 3 = 7

    Write a function:
    
        int solution(vector<int> &A);
    
    that, given a zero-indexed array A of N integers, returns the minimal cost of dividing chain into three pieces.
    
    For example, given:
                                A[0] = 5
                                A[1] = 2
                                A[2] = 4
                                A[3] = 6
                                A[4] = 3
                                A[5] = 7
                            
    the function should return 5, as explained above.
    
    Assume that:
    
        N is an integer within the range [5..100,000];
        each element of array A is an integer within the range [1..1,000,000,000].

    Complexity:
    
        expected worst-case time complexity is O(N);
        expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).

    Elements of input arrays can be modified.
 
*/

namespace MinimalCostToDivideChain;
class Solution
{
    public static int MinimalCostToDivideChain(int[] array)
    {
        int n = array.Length;
        int[] prefixSum = new int[n];
        int[] suffixSum = new int[n];

        // Calculate prefix and suffix sums
        for (int i = 1; i < n - 1; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + array[i];
        }

        for (int i = n - 2; i > 0; i--)
        {
            suffixSum[i] = suffixSum[i + 1] + array[i];
        }

        int minimalCost = int.MaxValue;

        // Iterate through possible breaking points
        for (int i = 1; i < n - 1; i++)
        {
            int cost = prefixSum[i - 1] + suffixSum[i + 1];
            minimalCost = Math.Min(minimalCost, cost);
        }

        return minimalCost;
    }
}
