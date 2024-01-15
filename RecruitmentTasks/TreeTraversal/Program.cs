using FluentAssertions;
using FluentAssertions.Execution;

namespace TreeTraversal;

public class Program
{
    public static void Main()
    {
        using (new AssertionScope())
        {
            /*
                        8
                      1   5

             */
            TreeTraversal.GetMaximumValuePerLevel(new Node()
            {
                Value = 8,
                Children = new List<Node>()
                        { new Node() { Value = 1, Children = new List<Node>() }, new Node() { Value = 5, Children = new List<Node>() } }
            }).Should().BeEquivalentTo(new List<int> { 8, 5 });
            /*
                            1
                    7       7       5
                            99
                            100
             */
            TreeTraversal.GetMaximumValuePerLevel(new Node()
            {
                Value = 1,
                Children = new List<Node>()
                    {
                        new Node() { Value = 7, Children = new List<Node>() },
                        new Node()
                        {
                            Value = 7,
                            Children = new List<Node>()
                                { new Node() { Value = 99, Children = new List<Node>() { new Node() { Value = 100, Children = new List<Node>() } } } }
                        },
                        new Node() { Value = 5, Children = new List<Node>() }
                    }
            }).Should().BeEquivalentTo(new List<int> { 1, 7, 99, 100 });
            /*
                            1
                     6          7       5
                  98   101      99
                 5 4   3 2    100 1
             */
            TreeTraversal.GetMaximumValuePerLevel(new Node()
            {
                Value = 1,
                Children = new List<Node>()
                    {
                        new Node()
                        {
                            Value = 6,
                            Children = new List<Node>()
                            {
                                new Node()
                                {
                                    Value = 98,
                                    Children = new List<Node>()
                                    {
                                        new Node() { Value = 5, Children = new List<Node>() }, new Node() { Value = 4, Children = new List<Node>() }
                                    }
                                },
                                new Node()
                                {
                                    Value = 101,
                                    Children = new List<Node>()
                                    {
                                        new Node() { Value = 3, Children = new List<Node>() }, new Node() { Value = 2, Children = new List<Node>() }
                                    }
                                }
                            }
                        },
                        new Node()
                        {
                            Value = 7,
                            Children = new List<Node>()
                                { new Node() { Value = 99, Children = new List<Node>() { new Node() { Value = 6, Children = new List<Node>() }, new Node(){Value = 1, Children = new List<Node>()} } } }
                        },
                        new Node() { Value = 5, Children = new List<Node>() }
                    }
            }).Should().BeEquivalentTo(new List<int> { 1, 7, 101, 6 });
        }

        Console.WriteLine("Success");
    }
}