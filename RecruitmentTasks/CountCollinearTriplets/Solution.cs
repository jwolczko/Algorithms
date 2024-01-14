/*
    Three points on a plane are called collinear if they lie on the same straight line. 
    For example, points with Cartesian coordinates (0, 1), (1, 3) and (3, 7) are collinear. Points (0, 0), (1, 1) and (2, 3) are not.
    
    Assume that the following declarations are given:
      
                                    
                                        struct Point2D {
                                        int x;
                                        int y;
                                        };
    
    Write a function:
    
        int solution(vector<Point2D> &A);
    
    that, given an array A containing Cartesian coordinates of N distinct points, counts the number of triplets (A[P], A[Q], A[R]) 
    such that 0 ≤ P < Q < R < N and the points A[P], A[Q], A[R] are collinear. 
    The function should return −1 if the number of such triplets exceeds 100,000,000.
    
    To access the coordinates of the K-th point (where 0 ≤ K < N), use the following syntax:
    
        A[K].x and A[K].y in all languages except PHP and Perl;
        $A[$K]->x and $A[$K]->y in PHP;
        $A[$K]->{x} and $A[$K]->{y} in Perl.
    
    For example, given A such that:    
    
                                A[0].x = 0  A[0].y = 0
                                A[1].x = 1  A[1].y = 1
                                A[2].x = 2  A[2].y = 2
                                A[3].x = 3  A[3].y = 3
                                A[4].x = 3  A[4].y = 2
                                A[5].x = 4  A[5].y = 2
                                A[6].x = 5  A[6].y = 1
                            
    the function should return 6, because the following six triplets of points are collinear:    
    
                                (A[0], A[1], A[2])
                                (A[0], A[1], A[3])
                                (A[0], A[2], A[3])
                                (A[1], A[2], A[3])
                                (A[2], A[4], A[5])
                                (A[3], A[5], A[6])
                            
    Assume that:
    
        N is an integer within the range [1..500];
        the coordinates of each point in array A are integers within the range [0..9,999];
        the elements of A are all distinct.

    Complexity:
    
        expected worst-case time complexity is O(N2*log(N));
        expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).

    Elements of input arrays can be modified.
 */


namespace CountCollinearTriplets;

class Solution
{
    public static int CountCollinearTriplets(List<Point2D> array)
    {
        int n = array.Count;
        int collinearTriplets = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (IsCollinear(array[i], array[j], array[k]))
                    {
                        collinearTriplets++;
                        if (collinearTriplets > 100000000)
                            return -1; // Return -1 if the limit is exceeded
                    }
                }
            }
        }

        return collinearTriplets;
    }

    public static bool IsCollinear(Point2D p, Point2D q, Point2D r)
    {
        return (q.Y - p.Y) * (r.X - q.X) == (r.Y - q.Y) * (q.X - p.X);
    }
}
