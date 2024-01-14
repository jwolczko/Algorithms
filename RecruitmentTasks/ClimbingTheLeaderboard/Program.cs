namespace ClimbingTheLeaderboard;

internal class Program
{

    static void Main(string[] args)
    {
        // Example usage:
        int n = int.Parse(Console.ReadLine());
        List<int> ranked = Console.ReadLine().Split().Select(int.Parse).ToList();
        int m = int.Parse(Console.ReadLine());
        List<int> player = Console.ReadLine().Split().Select(int.Parse).ToList();

        var result = Result.ClimbingLeaderboard(ranked, player);
        Console.WriteLine(string.Join("\n", result));
    }
}