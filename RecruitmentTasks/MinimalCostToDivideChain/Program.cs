namespace MinimalCostToDivideChain;
internal static class Program
{
    static void Main()
    {
        // Example Usage:
        int[] A = { 5, 2, 4, 6, 3, 7 };
        int minimalCost = Solution.MinimalCostToDivideChain(A);

        Console.WriteLine("Minimal Cost to Divide Chain: " + minimalCost);
    }
}