/*
A zero-indexed array A consisting of N integers is given. A pair of indices (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A. A slice is described as oscillating if:

    every two consecutive elements of the array A inside the slice are different, and
    no three consecutive elements of the array A inside the slice are monotonic.

More precisely, slice (P, Q) is alternating if:

    A[P] > A[P+1] < A[P+2] > ..., and so on, up to A[Q], or
    A[P] < A[P+1] > A[P+2] < ..., and so on, up to A[Q].

Note that if P = Q then the slice is also oscillating.

Write a function:

    int solution(vector<int> &A);

that, given an array A consisting of N integers, returns the size of the largest oscillating slice in A. If there is no such slice, the function should return 0.

For example, given array A such that:


                            A[0] =  5
                            A[1] =  0
                            A[2] = -2
                            A[3] =  6
                            A[4] =  3
                            A[5] =  4
                            A[6] =  4
                            A[7] = -3
                            A[8] =  5
                        
the function should return 5, because:

    (1, 5) is an oscillating slice of length 5 (A[1] > A[2] < A[3] > A[4] < A[5]), and
    all other oscillating slices in A are shorter.

Assume that:

    N is an integer within the range [0..100,000];
    each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].

Complexity:

    expected worst-case time complexity is O(N);
    expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
*/

namespace LargestOscillatingSlice;

class Solution
{
    public static int LargestOscillatingSlice(IEnumerable<int> array)
    {
        int n = array.Count();
        int result = 0;

        // Traverse the array to find the longest oscillating slice
        for (int i = 0; i < n; i++)
        {
            int count = 1;

            // Skip consecutive equal elements
            while (i + 1 < n && array.ElementAt(i) == array.ElementAt(i + 1))
            {
                i++;
            }

            // Check for an increasing or decreasing sequence
            while (i + 1 < n && 
                   i + 2 < n &&
                ((array.ElementAt(i) < array.ElementAt(i + 1) && array.ElementAt(i + 1) > array.ElementAt(i + 2)) ||
                 (array.ElementAt(i) > array.ElementAt(i + 1) && array.ElementAt(i + 1) < array.ElementAt(i + 2))))
            {
                i++;
                count++;
            }

            result = Math.Max(result, count);
        }

        return result;
    }    
}