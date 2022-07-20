using LeetCode.Problems.Stack;

namespace LeetCode.Tests.Stack
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()")]
        [InlineData("()[]{}")]
        [InlineData("([{}])")]
        public void GivenValidStringOfParentheses_ReturnTrue(string s)
        {
            var sut = new ValidParentheses();

            var isValid = sut.Solve(s);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData("(]")]
        public void GivenInvalidStringOfParentheses_ReturnFalse(string s)
        {
            var sut = new ValidParentheses();

            var isValid = sut.Solve(s);

            Assert.False(isValid);
        }
    }
}
