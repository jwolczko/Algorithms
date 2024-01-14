namespace ClimbingTheLeaderboard;

public class Result
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
    {
        ranked = ranked.Distinct().ToList(); // Remove duplicate scores from the ranked array
        List<int> playerRanks = new List<int>();

        int playerIndex = player.Count - 1;

        foreach (var score in player)
        {
            while (playerIndex >= 0 && score >= ranked[playerIndex])
            {
                playerIndex--;
            }

            if (playerIndex == -1)
            {
                playerRanks.Add(1);
            }
            else
            {
                playerRanks.Add(ranked.Count - playerIndex);
            }
        }

        playerRanks.Reverse(); // Reverse the list to match the expected output order
        return playerRanks.ToList();
    }

}
