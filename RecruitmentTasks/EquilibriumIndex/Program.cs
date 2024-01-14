namespace EquilibriumIndex;

internal class Program
{
    static void Main()
    {
        // Example Usage:
        int[] A = [ -1, 3, -4, 5, 1, -6, 2, 1 ];
        int equilibriumIndex = Solution.EquilibriumIndex(A);

        Console.WriteLine($"Equilibrium Index: {equilibriumIndex}");
    }
}