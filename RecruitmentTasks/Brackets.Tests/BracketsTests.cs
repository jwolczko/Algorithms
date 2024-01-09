namespace Brackets.Tests
{
    [TestClass]
    public class BracketsTests
    {
        [DataRow("(){}{(<>)}")]
        [DataRow("(((())))")]
        [DataTestMethod]
        public void StringShouldHaveValidBrackets(string stringToValid)
        {
            var isValid = Brackets.IsCorrect(stringToValid);
            isValid.Should().BeTrue();
        }


        [DataRow("()(()[")]
        [DataRow("())(")]
        [DataRow("<>)(}")]
        [DataTestMethod]
        public void StringShouldHaveNotValidBrackets(string stringToValid)
        {
            var isValid = Brackets.IsCorrect(stringToValid);
            isValid.Should().BeFalse();
        }
    }
}