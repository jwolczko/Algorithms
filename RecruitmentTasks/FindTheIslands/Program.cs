namespace FindTheIslands;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] map =
        [[0, 0, 1, 1, 0, 1, 0, 1],
         [0, 0, 1, 0, 0, 1, 1, 0],
         [1, 0, 0, 0, 0, 0, 0, 0],
         [0, 1, 0, 1, 0, 1, 0, 1],
         [0, 1, 0, 0, 0, 1, 0, 0],
         [0, 0, 0, 1, 0, 1, 0, 0]];

        var result = IslandFinder.CountIslands(map);
        Console.WriteLine($"Number of island {result}");
    }
}