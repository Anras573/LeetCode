namespace LeetCode.Tests.Arrays
{
    public class ValidAnagramTest
    {
        [Theory]
        [InlineData("anagram", "nagaram")]
        public void ReturnTrue_WhenParametersAreAnagrams(string s, string t)
        {
            var sut = new ValidAnagram();

            var isAnagram = sut.Solve(s, t);

            Assert.True(isAnagram);
        }

        [Theory]
        [InlineData("rat", "car")]
        public void ReturnFalse_WhenParametersAreNotAnagrams(string s, string t)
        {
            var sut = new ValidAnagram();

            var isAnagram = sut.Solve(s, t);

            Assert.False(isAnagram);
        }
    }
}
