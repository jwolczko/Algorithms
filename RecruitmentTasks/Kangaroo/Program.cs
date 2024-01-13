namespace Kangaroo;

internal class Program
{
    static void Main(string[] args)
    {
        string input = "0 3 4 2";
        string[] firstMultipleInput = input.Split(' ');
    
        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.Kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
