/*
A tree is an abstract data structure consisting of nodes.
Each node has only on parent and zero or more child nodes.
Each tree has one special node, called a root, which has no parent node.
A node is called an internal node if it has one or more children.

A tree can be represented by an array P where P[i] is the parent of node i.
For the root node r, P[r] equals -1.

Write a function that efficiently with respect to time used, count the number of internal nodes
in a given tree.

For example, the tree represented by the array {1, 3, 1, -1, 3} has 5 nodes, 0 to 4, of which 2 nodes
are internal nodes (only nodes 1 and 3 habe children).
*/

namespace TreeInternalNodeCounter;

public class TreeInternalNodeCounter
{
    public static int CountInternalNodes(int[] array)
    {
        int n = array.Length;
        int internalNodeCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (HasChildren(array, i))
            {
                internalNodeCount++;
            }
        }

        return internalNodeCount;
    }

    private static bool HasChildren(int[] array, int node)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == node)
            {
                return true;
            }
        }

        return false;
    }
}
