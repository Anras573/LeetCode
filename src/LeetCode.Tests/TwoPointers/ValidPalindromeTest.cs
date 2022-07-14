using LeetCode.Problems.TwoPointers;

namespace LeetCode.Tests.TwoPointers
{
    public class ValidPalindromeTest
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama")]
        [InlineData(" ")]
        public void ReturnTrue_WhenStringIsAValidPalindrome(string str)
        {
            var sut = new ValidPalindrome();

            var isValidPalindrome = sut.Solve(str);

            Assert.True(isValidPalindrome);
        }

        [Theory]
        [InlineData("race a car")]
        public void ReturnFalse_WhenStringIsNotAValidPalindrome(string str)
        {
            var sut = new ValidPalindrome();

            var isValidPalindrome = sut.Solve(str);

            Assert.False(isValidPalindrome);
        }
    }
}
