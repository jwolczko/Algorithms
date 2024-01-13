
namespace BetweenTwoSets;

internal class Program
{
    static void Main(string[] args)
    {
        string[] firstMultipleInput = "2 3".Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = "2 4".Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = "16 32 96".TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.GetTotalX(arr, brr);       

        Console.WriteLine(total);
    
    }
}
