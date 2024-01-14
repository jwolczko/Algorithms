namespace BackspaceStringProcessor;

internal static class Program
{
    static void Main()
    {
        string input = "a#bc#d";
        string result = BackspaceStringProcessor.ProcessBackspace(input);

        Console.WriteLine($"Processed String: {result}");
    }
}