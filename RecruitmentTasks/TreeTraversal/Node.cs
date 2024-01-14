namespace TreeTraversal;

public class Node
{
    public int Value { get; set; }

    public List<Node> Children { get; set; }

    public Node()
    {
        Children = new List<Node>();
    }

    public Node(int value)
    {
        Value = value;
        Children = new List<Node>();
    }
}
