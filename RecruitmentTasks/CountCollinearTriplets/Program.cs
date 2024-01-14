namespace CountCollinearTriplets;

internal static class Program
{
    static void Main()
    {
        List<Point2D> points =
        [
            new() { X = 0, Y = 0 },
            new() { X = 1, Y = 1 },
            new() { X = 2, Y = 2 },
            new() { X = 3, Y = 3 },
            new() { X = 3, Y = 2 },
            new() { X = 4, Y = 2 },
            new() { X = 5, Y = 1 }
        ];

        int result = Solution.CountCollinearTriplets(points);
        Console.WriteLine("Number of Collinear Triplets: " + result);
    }
}