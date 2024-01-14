namespace TreeInternalNodeCounter;
internal static class Program
{
    static void Main()
    {
        int[] treeArray = [ 1, 3, 1, -1, 3 ];
        int result = TreeInternalNodeCounter.CountInternalNodes(treeArray);

        Console.WriteLine($"Number of internal nodes: {result}");
    }
}