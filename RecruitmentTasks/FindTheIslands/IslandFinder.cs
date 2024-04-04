namespace FindTheIslands;

public class IslandFinder
{
    public static int CountIslands(int[][] map)
    {
        int islandCount = 0;
        int rows = map.Length;
        int cols = map[0].Length;

        // Create a boolean array to mark visited cells
        bool[][] visited = new bool[rows][];

        for (int i = 0; i < rows; i++)
        {
            visited[i] = new bool[cols];
        }

        // Traverse through all cells of the given matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // If a cell with value 1 is not visited yet, then a new island is found
                if (map[i][j] == 1 && !visited[i][j])
                {
                    // Call DFS for the current cell to mark all adjacent cells as visited
                    DFS(map, visited, i, j);
                    islandCount++;
                }
            }
        }

        return islandCount;
    }

    // Depth-First Search to mark all adjacent cells of an island as visited
    private static void DFS(int[][] map, bool[][] visited, int row, int col)
    {
        // Define the 8 possible directions for movement
        int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

        visited[row][col] = true;

        // Traverse all adjacent cells
        for (int k = 0; k < 8; k++)
        {
            int newRow = row + dr[k];
            int newCol = col + dc[k];

            // Check if the adjacent cell is within the bounds of the matrix and has value 1
            if (IsValidCell(newRow, newCol, map.Length, map[0].Length) && map[newRow][newCol] == 1 && !visited[newRow][newCol])
            {
                DFS(map, visited, newRow, newCol);
            }
        }
    }

    // Check if a cell is within the bounds of the matrix
    private static bool IsValidCell(int row, int col, int numRows, int numCols)
    {
        return row >= 0 && row < numRows && col >= 0 && col < numCols;
    }
}
