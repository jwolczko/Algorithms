/*
Assume "#" is like a backspace in string.This means that string "a#bc#d" actually is "bd"

Your task is to process a string with "#" symbols.
*/

namespace BackspaceStringProcessor;

public class BackspaceStringProcessor
{
    public static string ProcessBackspace(string input)
    {
        return ProcessBackspace(input, '#');
    }

    public static string ProcessBackspace(string input, char backspaceCharacter)
    {
        Stack<char> stack = new();

        foreach (char ch in input)
        {
            if (ch == backspaceCharacter && stack.Count > 0)
            {
                stack.Pop();
                continue;
            }
            stack.Push(ch);
        }

        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);

        return new string(resultArray);
    }
}