using LeetCode.Problems.SlidingWindow;

namespace LeetCode.Tests.SlidingWindow
{
    public class BestTimeToBuyAndSellStockTest
    {
        [Theory]
        [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void GivenArrayOfPrices_ReturnMaximumProfit(int[] prices, int expectedProfit)
        {
            var sut = new BestTimeToBuyAndSellStock();

            var profit = sut.Solve(prices);

            Assert.Equal(expectedProfit, profit);
        }
    
    }
}
