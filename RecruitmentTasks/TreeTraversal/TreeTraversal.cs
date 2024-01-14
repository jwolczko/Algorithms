/*
Given a tree
                          8
             1                         5
   11        3       7           11         19
1 2 3 4   99 4 5   1  45       11  23     1  2  3

return maximum node value on each level. Result for given example should be: 8, 5, 19, 99
*/


namespace TreeTraversal;

public class TreeTraversal
{
    public static IEnumerable<int> GetMaximumValuePerLevel(Node root)
    {
        if (root == null)
            yield break;

        Queue<Node> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int levelMax = int.MinValue;

            for (int i = 0; i < levelSize; i++)
            {
                Node currentNode = queue.Dequeue();
                levelMax = Math.Max(levelMax, currentNode.Value);

                foreach (var child in currentNode.Children)
                {
                    if (child != null)
                        queue.Enqueue(child);
                }
            }

            yield return levelMax;
        }
    }
}
