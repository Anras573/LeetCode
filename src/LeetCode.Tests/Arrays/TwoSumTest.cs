namespace LeetCode.Tests.Arrays
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void GivenArrayofIntegersAndTarget_ReturnArrayOfIndices_WhichAmountToTarget(int[] nums, int target, int[] expectedIndices)
        {
            var sut = new TwoSum();

            var indices = sut.Solve(nums, target);

            Assert.Collection(
                indices,
                i => Assert.Equal(expectedIndices[0], i),
                i => Assert.Equal(expectedIndices[1], i));
        }
    }
}
