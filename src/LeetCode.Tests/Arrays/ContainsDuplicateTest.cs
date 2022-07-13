using LeetCode.Problems.Arrays;

namespace LeetCode.Tests.Arrays
{
    public class ContainsDuplicateTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 })]
        [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
        public void ReturnsTrue_WhenDuplicateIsFound(int[] nums)
        {
            var sut = new ContainsDuplicate();

            var containsDuplicate = sut.Solve(nums);

            Assert.True(containsDuplicate);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 })]
        public void ReturnsFalse_WhenNoDuplicateIsFound(int[] nums)
        {
            var sut = new ContainsDuplicate();

            var containsDuplicate = sut.Solve(nums);

            Assert.False(containsDuplicate);
        }
    }
}
