namespace Palindrome;

public static class Palindrome
{
    public static bool IsPalindrome(string value)
    {
        if(string.IsNullOrEmpty(value)) return true;

        string valueWithoutSpaces = value.Replace(" ", String.Empty);
        string reversedValue = new string(valueWithoutSpaces.Reverse().ToArray());

        return valueWithoutSpaces.Equals(reversedValue, StringComparison.InvariantCultureIgnoreCase);
    }
}
