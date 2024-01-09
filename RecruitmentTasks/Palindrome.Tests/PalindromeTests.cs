namespace Palindrome.Tests;

[TestClass]
public class PalindromeTests
{
    [DataRow("Do geese see God")]
    [DataRow("kayak")]
    [DataRow("Devil lived")]
    [DataRow("A to kanapa pana Kota")]
    [DataTestMethod]
    public void StringShouldBePalindrome(string palindromeString)
    {
        var isPalindrome = Palindrome.IsPalindrome(palindromeString);

        isPalindrome.Should().BeTrue();
    }
}